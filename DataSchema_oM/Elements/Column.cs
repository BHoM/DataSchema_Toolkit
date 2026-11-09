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
using System;
using System.ComponentModel;

namespace BH.oM.DataSchema.Elements
{
    [Description("The columns of a building: typical material, size and count per floor.")]
    public class Column : BaseStructuralElement
    {
        [DisplayText("Typical columns per floor")]
        [Description("Median number of columns crossing each floor, from ground up to the floor below the roof. " +
                     "Derivation: At each merged floor level from ground up to the floor below the roof, count the columns crossing a horizontal plane 1.0 m above the floor; a column through several storeys counts on each. Excludes columns shorter than 60% of slab-to-slab height, and thin posts (HSS, SHS, RHS, CHS or WP up to 110 mm thick) unless they are the most common type. Median across floors. Only the typical material is counted unless it is under 50% of all columns, in which case all are counted. " +
                     "Edge cases: Median, not most frequent. Wall-bearing buildings with no columns are null, not 0, so they can't be told apart from missing data. Light-gauge studs are counted as columns. " +
                     "Aliases: columns per floor, column count per floor.")]
        public virtual int? TypicalCountPerSlab { get; set; }
    }
}
