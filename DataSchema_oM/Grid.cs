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
using System.ComponentModel;

namespace BH.oM.DataSchema
{
    [Description("Typical column grid spacing of a building, in the primary and secondary gridline directions.")]
    public class Grid : BHoMObject
    {
        [DisplayText("Typical grid spacing, primary direction")]
        [Description("Typical centre-to-centre spacing between adjacent column gridlines in the primary direction (the family of parallel gridlines with the most lines; not the model's global X axis). " +
                     "Derivation: Gridline curves are reduced to straight lines (arcs and polylines become a line between their furthest end points). Lines within 2\u00B0 of each other form a family of at least 2 lines; the largest family is X, the second largest is Y. Gaps between adjacent lines are measured, ignoring gaps under 0.5 m, and rounded to 0.1 m. The result is the median of the gaps in the most common rounded value. " +
                     "Edge cases: Intended to cover column gridlines only, but the current code counts all gridlines, so secondary and facade grids pull results below 4 m. Radial or non-orthogonal grids are reduced to straight lines and can give unrepresentative families. Where the grid varies across the plan, the most frequent spacing wins, not the largest. " +
                     "Aliases: column grid, grid spacing, bay size, bay width.")]
        [Length]
        public virtual double? TypicalXSpacing { get; set; }

        [DisplayText("Typical grid spacing, secondary direction")]
        [Description("Typical centre-to-centre spacing between adjacent column gridlines in the second-largest gridline family. " +
                     "Derivation: Gridline curves are reduced to straight lines (arcs and polylines become a line between their furthest end points). Lines within 2\u00B0 of each other form a family of at least 2 lines; the largest family is X, the second largest is Y. Gaps between adjacent lines are measured, ignoring gaps under 0.5 m, and rounded to 0.1 m. The result is the median of the gaps in the most common rounded value. " +
                     "Edge cases: Intended to cover column gridlines only, but the current code counts all gridlines, so secondary and facade grids pull results below 4 m. Radial or non-orthogonal grids are reduced to straight lines and can give unrepresentative families. Where the grid varies across the plan, the most frequent spacing wins, not the largest. " +
                     "Aliases: column grid, grid spacing, bay size, bay depth.")]
        [Length]
        public virtual double? TypicalYSpacing { get; set; }

        [Description("A field added to test the sync.")]
        public virtual int SyncTestField { get; set; } = 0;
    }
}
