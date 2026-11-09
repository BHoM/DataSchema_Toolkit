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

namespace BH.oM.DataSchema.Elements
{
    [Description("The foundations of a building, piled or not: pile count and volume.")]
    public class PileFoundation : BaseStructuralElement
    {
        [DisplayText("Number of piles")]
        [Description("Total number of piles in the building's foundations, excluding pile caps. " +
                     "Null when no piles are found, including pad and raft foundations. " +
                     "Derivation: Count Structural Foundations elements whose type name or name contains pile, piling, driven, bored, CFA or auger. " +
                     "Edge cases: Piled rafts count the piles only. Piles are always modelled in Structural Foundations in BH models. Counts Revit elements; pile groups modelled as a single family are rare. " +
                     "Aliases: pile count, number of piles.")]
        public virtual int? PileCount { get; set; }

        [DisplayText("Total pile volume")]
        [Description("Summed volume of all piles, in whatever material the piles are made of; pile caps excluded. " +
                     "Derivation: Sum of Volume for the elements counted in PileCount, rounded to 0.01 m\u00B3. " +
                     "Edge cases: One total across materials, so steel and concrete piles aren't comparable; filter by TypicalType. Pile caps are excluded here but included in Building.MaterialVolumesBelowGround. " +
                     "Aliases: piling volume, pile concrete volume.")]
        [Volume]
        public virtual double? PileVolume { get; set; }
    }
}
