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
using System.ComponentModel;

namespace BH.oM.DataSchema.Elements
{
    [Description("The beams of a building: typical material, size and count per floor.")]
    public class Beam : BaseStructuralElement
    {
        [DisplayText("Typical material")]
        [Description("The predominant material of this element type in the building. " +
                     "" +
                     "Derivation: Column: most frequent material by count among columns at least 60% of slab-to-slab height. Beam: material with the largest total plan length on suspended floors. " +
                     "Edge cases: Columns become Concrete - In-Situ when the slab is concrete and RC columns number at least 80% of the steel columns. Beams become Concrete - In-Situ when the columns are concrete and concrete beams are at least a third of the beam length. " +
                     "Aliases: frame material, primary material.")]
        public virtual StructuralMaterial? TypicalMaterial { get; set; }

        [DisplayText("Typical beams per floor")]
        [Description("Median number of beam elements per level, across all levels that have beams. " +
                     "Derivation: Each beam is assigned to the nearest raw Revit level by its underside; beams are counted per level and the median taken over levels that have beams. All materials and beam types are included (primary, secondary, edge, lintels, ground beams) on every level, including roof and basement. " +
                     "Edge cases: Median. Raw Revit levels are used, so split levels are counted separately (unlike the column count). Counts Revit elements, so a continuous beam modelled in segments counts several times. " +
                     "Aliases: beams per floor, beam count per floor.")]
        public virtual int? TypicalCountPerSlab { get; set; }
    }
}
