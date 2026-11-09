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
using BH.oM.Quantities.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.DataSchema
{
    [Description("Building-level properties of a precedent model: storey counts and material volumes split at ground level.")]
    public class Building : BHoMObject
    {
        [DisplayText("Storeys above ground")]
        [Description("Number of storeys from ground level upwards. The roof level is not a storey; roof-top plant levels are counted. " +
                     "Derivation: Merge levels within 1.5 m of each other. Drop reference datums, mezzanines under 25% of the largest floor, and levels with no slab top or column end. Total storeys = levels - 1; above ground = total - StoreysBelowGround. " +
                     "Edge cases: Roof-top plant levels with slabs or columns count as storeys. Split levels within 1.5 m of each other merge into one storey. Small mezzanines are excluded; mezzanines of 25% or more of the largest floor count. \"G+7\" in reports means 8 storeys above ground. " +
                     "Aliases: number of floors, floors above ground, storey count.")]
        public virtual int? StoreysAboveGround { get; set; }

        [DisplayText("Storeys below ground")]
        [Description("Number of basement storeys below ground level. " +
                     "Derivation: If any level lies within 0.5 m of 0.0: count merged levels more than 0.5 m below 0.0. Otherwise use the wall rule: working upwards from the lowest level, a level is below ground if its longest connected wall chain is more than 80% of the slab plan perimeter; counting stops after two consecutive failures. " +
                     "Edge cases: Assumes the model's 0.0 is ground floor level; models set out to sea-level datum fall back to the wall rule. Partial or half basements may be counted or missed depending on the wall chain. " +
                     "Aliases: basement levels, basements, number of basements.")]
        public virtual int? StoreysBelowGround { get; set; }

        [DisplayText("Material volumes above ground")]
        [Description("Total element volume per material for everything above ground level, excluding foundations. Unit: m\u00B3 per key. " +
                     "Dictionary keys, where a missing key means none found (0 m\u00B3): Concrete - In-Situ (name or material contains concrete, RC or slab, includes PT concrete); Concrete - Precast (contains precast or PC); Steel (contains steel, ASTM or a section prefix: W, HSS, UC, UB, RHS, SHS, pipe); Steel Plate (contains plate); Metal - Light Gauge (contains LG or light gauge, and metal); Metal Deck (deck or metal, without concrete topping keywords); Composite Metal Deck (deck or metal with concrete, topping, slab, NWC or LWC; concrete and deck are combined); Composite (contains composite, SRC, filled or encased; steel and concrete are combined); Timber - CLT (contains CLT or cross laminated); Timber - LVL (contains LVL or laminated veneer); Timber - Glulam (contains glulam or glue lam); Timber - Sawn (contains sawn); Timber - General (contains timber or wood, with no more specific match); Masonry - Concrete Blockwork (contains masonry or CMU); Masonry - Brickwork (contains brick); Gabion - Stone (contains stone or gabion); Other (no keyword match). " +
                     "Derivation: Classify each element by keyword rules, checked in order against Type Name, Name, BHE_Material and Structural Material. Sum Volume per material for elements whose base (MinZ) is at or above ground level, excluding Structural Foundations. With no basement, all non-foundation elements count. " +
                     "Edge cases: Elements crossing ground level are assigned by their base, so a basement-to-L1 column counts wholly below ground. Composite materials store concrete and steel as one volume. Rarely, non-structural elements are included, usually under Other. Short keywords match anywhere in a name (e.g. w, pc, rc) and can misclassify; word-boundary matching proposed. Keys use the detailed material vocabulary, which differs from the element TypicalMaterial (e.g. Steel vs Steel - Hot Rolled). Reinforcement is not captured separately. " +
                     "Aliases: material quantities, material take-off, MTO.")]
        [Volume]
        public virtual Dictionary<string, double> MaterialVolumesAboveGround { get; set; }

        [DisplayText("Material volumes below ground")]
        [Description("Total element volume per material for everything below ground level, plus all foundations. Unit: m\u00B3 per key. " +
                     "Dictionary keys: the same keys as MaterialVolumesAboveGround. " +
                     "Derivation: Elements whose base is below ground level, plus all Structural Foundations wherever they sit. " +
                     "Edge cases: With no basement, this holds foundations only; ground beams modelled as framing count as above ground. Same keyword and composite caveats as MaterialVolumesAboveGround. " +
                     "Aliases: substructure quantities, below-ground MTO.")]
        [Volume]
        public virtual Dictionary<string, double> MaterialVolumesBelowGround { get; set; }
    }
}
