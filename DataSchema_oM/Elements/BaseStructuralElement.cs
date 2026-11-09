/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2024, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *
 *
 * The BHoM is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3.0 of the License, or
 * (at your option) any later version.
 *
 * The BHoM is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.
 */

using BH.oM.Base;
using BH.oM.Base.Attributes;
using BH.oM.DataSchema.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.DataSchema.Elements
{
    [Description("Base class of the structural element types of a building (column, beam, slab, roof and pile foundation): the properties they share.")]
    public abstract class BaseStructuralElement : BHoMObject
    {
        [DisplayText("Refurbishment")]
        [Description("True when the building retains existing structure (refurbishment or retrofit) rather than being wholly new-build; false when no existing structure is retained. " +
                     "Derivation: Current code: true when more than 10% of all elements have a Phase Demolished value other than none. " +
                     "Edge cases: Retained frames with no modelled demolition currently read as false; 63NBS is the only true value in the dataset. Same value on every subclass for now. " +
                     "Aliases: retrofit, refurb, existing building reuse, retained structure.")]
        public virtual bool? IsRefurbished { get; set; }

        [DisplayText("Typical size")]
        [Description("The Revit type name of the representative member of this element type, e.g. a section designation or slab description. " +
                     "Derivation: Column: most frequent type name among columns of the typical material. Beam: type with the most plan length, among types at or above the 25th length-weighted percentile of section size (ignores secondary members) and excluding non-floor names (lintel, balustrade, ground beam etc.). Slab: type name with the largest area on suspended floors, excluding ground-bearing types. " +
                     "Aliases: section size, member size, type name.")]
        public virtual string TypicalSize { get; set; }

        [DisplayText("Typical type")]
        [Description("The predominant system or type for this element. " +
                     "Null for N/A or Unknown, and for Column and Beam. Slab and Roof use the slab types; PileFoundation uses the foundation types (and covers all foundation types, piled or not). " +
                     "Derivation: Slab: type of the type name with the largest area on suspended floors. Roof: the same, at or above the roof level. PileFoundation: keyword rules for piles (excluding pile caps), raft, vibro and stone, then the dominant pile or foundation material. " +
                     "Edge cases: Slab type comes from the single largest type name, not the largest total area per type. PileFoundation also holds non-piled foundations (pads, rafts). Some piled foundations are not drawn as 3D objects and are therefore not counted. " +
                     "Aliases: slab type, floor type, roof type, foundation type.")]
        public virtual StructuralElementType? TypicalType { get; set; }

        [DisplayText("Material distribution")]
        [Description("Breakdown of this element type by material or type. The unit depends on the subclass: count (Column, Beam) or m\u00B2 (Slab). " +
                     "Null when there are no elements, and for Roof and PileFoundation. " +
                     "Dictionary keys: the TypicalMaterial values (Column, Beam) or the slab TypicalType values (Slab). " +
                     "Derivation: Column: count per material among columns at least 60% of slab-to-slab height. Beam: count per material, all beams. Slab: total area per slab type, non-roof slabs only. " +
                     "Edge cases: Not volume; use Building.MaterialVolumes for m\u00B3. Beam counts include all beams; column counts include thin posts, even if not structural. " +
                     "Aliases: material split, material breakdown.")]
        public virtual Dictionary<string, double> MaterialDistribution { get; set; }
    }
}
