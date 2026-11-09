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
using BH.oM.DataSchema.Enums;
using System;
using System.ComponentModel;

namespace BH.oM.DataSchema.Systems
{
    [Description("The building-level lateral (stability) structural system, and the thickness of its shear walls.")]
    public class LateralStructuralSystem : BHoMObject
    {
        [DisplayText("Lateral system")]
        [Description("Building-level system resisting horizontal loads, as Material: Type. Above-ground shear walls take priority, then bracing; moment frames are assumed when neither is present. " +
                     "Derivation: Walls at least 60% of the typical slab-to-slab height; a material counts if it is more than 10% of those walls (priority concrete, then masonry, then timber). Bracing: more than 10 Structural Columns with plan offset greater than 30% of height; timber if most are timber, otherwise steel. No walls or bracing: moment frame from Column.TypicalMaterial (after concrete-frame rules). " +
                     "Edge cases: Basement and retaining walls must not count; the current code includes them. Wall material priority means a timber building with a concrete core is Concrete: Shear Walls. Bracing is detected from Structural Columns only; any non-timber bracing (including concrete raking members) is classed as steel. There is no timber moment-frame option, so timber frames without walls or bracing give Other. Timber: Shear Panels and the Timber Shear Walls wording in hybrids are the same concept. " +
                     "Aliases: stability system, lateral load resisting system, bracing system.")]
        public virtual LateralSystemType? SystemType { get; set; }

        [DisplayText("Typical shear wall thickness")]
        [Description("Most frequent thickness of the walls in the dominant lateral wall material (concrete, masonry or timber panels). " +
                     "Derivation: Most frequent value, by count, of the Width property of walls in the dominant wall material. The model's length unit is detected against the wall plan extent; the result is rounded to the nearest 5 mm. " +
                     "Edge cases: Includes masonry blockwork and CLT panel thickness when those are the lateral wall material. For hybrid systems this is the wall thickness, not the bracing. Basement and retaining walls must be excluded. Where two thicknesses are equally common, the code takes the first. " +
                     "Aliases: core wall thickness, shear panel thickness.")]
        [Length]
        public virtual double? TypicalShearWallThickness { get; set; }
    }
}
