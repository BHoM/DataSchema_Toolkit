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
    [Description("Typical storey properties of a building: slab-to-slab height, and the floor slab areas below and at the roof.")]
    public class Storey : BHoMObject
    {
        [DisplayText("Typical slab-to-slab height")]
        [Description("Median vertical distance between consecutive storey levels across the building. BH structural models set levels at top of structural slab, so this is the slab-to-slab height. " +
                     "Derivation: Merge levels and drop reference or empty levels. Take the gaps between consecutive levels, ignore gaps under 2.0 m unless nothing else remains, and take the median, rounded to 0.01 m. Median, not most frequent. " +
                     "Edge cases: Includes basement storeys and roof plant levels. Assumes levels are at top of structural slab; where a model uses finished floor level, the value is storey height. Double-height spaces only affect the result if the intermediate level is missing from the model. " +
                     "Aliases: slab-to-slab height, floor-to-floor height, storey height.")]
        [Length]
        public virtual double? TypicalHeight { get; set; }

        [DisplayText("Floor slab area, excluding roof")]
        [Description("Total area of all floor slabs below the roof level, including ground-bearing and basement slabs. " +
                     "Derivation: Sum the Area property of Revit Floors, converted to m\u00B2 (unit detected against the plan extent). Slabs are assigned to their nearest merged level. Everything below the roof level counts; the roof level is the highest level whose slab area is at least 50% of the level below. " +
                     "Edge cases: Lower roofs at set-backs or podiums count here, not in RoofArea. Overlapping floor elements (e.g. thickenings or drops modelled as separate floors) are double-counted. Rarely includes non-structural floors such as finishes. Mezzanines are included. " +
                     "Aliases: gross slab area, total floor area, GIA.")]
        [Area]
        public virtual double? NonRoofArea { get; set; }

        [DisplayText("Roof slab area")]
        [Description("Total area of floor slabs at or above the main roof level, including pop-ups. " +
                     "Null when there are no floor slabs; 0 only when slabs exist but none are at roof level. " +
                     "Derivation: Same calculation as NonRoofArea, summing slabs at or above the roof level. " +
                     "Edge cases: A roof plant level with at least 50% of the area of the level below becomes the roof; the main roof beneath it counts as non-roof. Set-back and podium roofs are not counted here. Structural roofs are modelled as Revit Floors in BH models. " +
                     "Aliases: roof area, roof slab area.")]
        [Area]
        public virtual double? RoofArea { get; set; }
    }
}
