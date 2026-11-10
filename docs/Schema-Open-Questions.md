# Open questions on the C# schema

Things in `DataSchema_oM` that I was unsure about when turning *EmbodiedCarbon_oM_1_MB Update.pdf* into classes. Each has the choice I made, so nothing is blocked; tell me the answer and I will update the properties.

## Structure

1. **How the classes link.** The PDF lists the classes and their properties but not which class holds which (for example, whether a `Building` holds a `Grid`, a `Storey`, the elements and the systems, or whether a `Project` holds a `Building`). I added no link properties, so every class stands alone. Which links do you want, and as single objects or lists?
2. **Namespace.** I used `BH.oM.DataSchema`, with `.Elements`, `.Systems` and `.Enums`, to match the `RootNamespace` of the project. The template's `ExampleObject` uses `BH.oM.Adapters.DataSchema`. I left `ExampleObject` and the example methods of `DataSchema_Engine` as they are; say if you want them removed.
3. **`Project.Name`.** The PDF's project name is the `Name` that every BHoM object already has, so I did not add a property. It defaults to `""`, not null, and the PDF's remark that the data mixes short codes (QPR, 63NBS) with full names is not in a description. Do you want that remark added somewhere?
4. **`BaseStructuralElement` is abstract.** The PDF calls it the "base parent class", so it cannot be created on its own. `Column`, `Beam`, `Roof`, `Slab` and `PileFoundation` inherit from it.

## BHoM base classes and interfaces

5. **Not implemented:** `IElement1D`, `IElement2D`, `IFramingElement` and the other dimensional interfaces need geometry (a location or a curve), which these classes do not have. `Environment_oM.Building`, `Spatial_oM.Grid` and `Spatial_oM.Level` exist in the BHoM repo, but they are geometric classes with different properties, so `Building`, `Grid` and `Storey` inherit only from `BHoMObject`.
6. **Same names as BHoM classes.** `Beam`, `Column`, `Roof`, `PileFoundation`, `Building` and `Grid` also exist in other BHoM assemblies (`Physical_oM`, `Environment_oM`, `Spatial_oM`). The namespaces differ, but a file that imports both will need to qualify them. Rename any?

## Nullability

7. **Nullable values.** Every property the PDF marks "Nullable: Yes" is a nullable type (`int?`, `double?`, `bool?`, `SomeEnum?`), because the PDF depends on the difference between null and 0 (for example `RoofArea`, `PileCount`, `TypicalCountPerSlab`). Strings and dictionaries marked nullable default to null; `Project.Number` ("Nullable: No") defaults to `""`. BHoM often uses `double.NaN` or an `Undefined` enum member for "no value" instead. Which do you want?
8. **Enum "Other" and null.** The PDF distinguishes `Other` (identified but not mapped) from null (missing data). I kept both: the enums have `Other`, and the properties are nullable.

## Enums

9. **Stored text versus member names.** (Decided: migrate the data.) The member name is what is stored, in JSON and as a dictionary key, so the PDF text such as `Steel - Hot Rolled` becomes `SteelHotRolled` in the existing data, once. The member `DisplayText` is removed, since it is not carried to Python; the PDF text stays at the start of each member's `Description`. Python users will own the list from now on: they edit the Python enum and `py2cs` raises the linked C# change, so the names have to be written the way C# needs them (PascalCase, no spaces).

10. **One enum for `TypicalType`.** The property is on the base class, but Slab and Roof use slab types and PileFoundation uses foundation types, so `StructuralElementType` holds both lists (`Foundation...` members for the foundations; `Other` is shared). Nothing stops a Slab from holding a foundation type, and the 11 slab members now exist twice (also in `SlabType`, the key of `Slab.MaterialDistribution`). Recommended, the same fix as for `MaterialDistribution`: take `TypicalType` off the base class and give Slab and Roof a `SlabType` property and PileFoundation a `FoundationType` property, then delete `StructuralElementType`. Do you agree?

11. **Dictionary keys.** (Decided: enum keys for the material distributions.) `MaterialDistribution` is no longer on `BaseStructuralElement`; `Column` and `Beam` have `Dictionary<StructuralMaterial, double>` and `Slab` has `Dictionary<SlabType, double>`. `Roof` and `PileFoundation` have none, since the PDF says it is null for them. The C# to Python read of an enum-keyed dictionary now works (BHoM writes it as an array of `k`/`v` objects, which the support layer of BHoM_PythonSchema reads and writes), checked with the real BHoM serialiser. `MaterialVolumesAboveGround` and `MaterialVolumesBelowGround` are still `Dictionary<string, double>`: their 17 keys (such as `Steel Plate`, `Gabion - Stone`) have no enum yet. Add a `MaterialKey` enum for them now? (The fix is in, so the keys can be enum-typed once the existing data is migrated to the member names.)

12. **Inconsistent wording in the PDF.** I copied these as written; tell me which are intended:
    - `Concrete Piled Raft` has no colon (the other foundation types do).
    - Some values repeat the group, such as `Other: Other` and `Hybrid: Hybrid`.
    - `Timber: Shear Panels` and the hybrid `Timber Shear Walls and ...` are noted in the PDF as the same concept, but are two different texts.
    - `Timber: Shear Walls and Braced Frames` is not labelled `Hybrid`, unlike the other combinations.
    - `Steel: Steel Plate` and `Steel: Hot Rolled Steel` repeat the word `Steel`.

## Units and values

13. **Units.** Every unit in the PDF is already SI (m, m², m³), so no value is converted. Lengths, areas and volumes carry the BHoM `Length`, `Area` and `Volume` attributes. `MaterialDistribution` (a count for Column and Beam, m² for Slab) and the two `MaterialVolumes` dictionaries have no unit attribute; the unit is in their descriptions.
14. **Depths.** `TypicalTypeDepth` and `TypicalShearWallThickness` are in metres, as the PDF says. The derivation text says the code reads the number from the name (mm or inches) and rounds to 5 mm; I kept that text.
15. **Characters lost in the PDF.** The depth derivation reads "(mm, , in)", where a unit symbol was lost in the PDF; I wrote "(mm, in)". Please check what the missing unit is. Also check my readings of "2°" (degrees) and "m³ per key".
16. **Names that say more than they mean.** `TypicalCountPerSlab` is displayed as "columns per floor" and "beams per floor"; I kept the name from the PDF. `MaterialDistribution` refers to `Building.MaterialVolumes`, which is not a property name (the properties end in `AboveGround` and `BelowGround`); I kept the text.

## Descriptions

17. **What is in each description.** The `Description` joins, in order: the definition, what null means (where the PDF says), the derivation from Revit, the edge cases, and the aliases. The display name is in a `DisplayText` attribute, and the example questions are left out. Some edge cases state what the code should do rather than what it does (for example "Basement and retaining walls must not count; the current code includes them"); I copied them as written. Is this the right content, and are the descriptions too long?

## Build

18. **Post-build copy.** Building the solution copies `DataSchema_oM.dll` and `DataSchema_Engine.dll` into `C:\ProgramData\BHoM\Assemblies`, as the template's project files say. I built the solution once, so the copies there are now these versions.
19. **Python schema.** I have not run the Python generator on these classes yet, so I have not checked how the nullable enums and the `Volume` attribute on a dictionary come out.
