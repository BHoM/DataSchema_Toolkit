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

using BH.oM.Base.Attributes;
using System.ComponentModel;

namespace BH.oM.DataSchema.Enums
{
    [Description("Building-level system resisting horizontal loads, as Material: Type.")]
    public enum LateralSystemType
    {
        [DisplayText("Concrete: Shear Walls")]
        [Description("Concrete: Shear Walls: Concrete is more than 10% of full-height walls; no bracing.")]
        ConcreteShearWalls,

        [DisplayText("Masonry: Shear Walls")]
        [Description("Masonry: Shear Walls: Masonry or brick is more than 10% of full-height walls, concrete is not; no bracing.")]
        MasonryShearWalls,

        [DisplayText("Timber: Shear Panels")]
        [Description("Timber: Shear Panels: Timber is more than 10% of full-height walls, concrete and masonry are not; no bracing.")]
        TimberShearPanels,

        [DisplayText("Steel: Braced Frames")]
        [Description("Steel: Braced Frames: No significant walls; more than 10 diagonal members, mostly non-timber.")]
        SteelBracedFrames,

        [DisplayText("Timber: Braced Frames")]
        [Description("Timber: Braced Frames: No significant walls; more than 10 diagonal members, mostly timber.")]
        TimberBracedFrames,

        [DisplayText("Concrete: Moment Frames")]
        [Description("Concrete: Moment Frames: No walls or bracing; typical column is concrete (in-situ, precast or PT).")]
        ConcreteMomentFrames,

        [DisplayText("Steel: Moment Frames")]
        [Description("Steel: Moment Frames: No walls or bracing; typical column is steel (hot rolled or light gauge).")]
        SteelMomentFrames,

        [DisplayText("Hybrid: Concrete Shear Walls and Steel Braced Frames")]
        [Description("Hybrid: Concrete Shear Walls and Steel Braced Frames: Both detected.")]
        HybridConcreteShearWallsAndSteelBracedFrames,

        [DisplayText("Hybrid: Concrete Shear Walls and Timber Braced Frames")]
        [Description("Hybrid: Concrete Shear Walls and Timber Braced Frames: Both detected.")]
        HybridConcreteShearWallsAndTimberBracedFrames,

        [DisplayText("Hybrid: Masonry Shear Walls and Steel Braced Frames")]
        [Description("Hybrid: Masonry Shear Walls and Steel Braced Frames: Both detected.")]
        HybridMasonryShearWallsAndSteelBracedFrames,

        [DisplayText("Hybrid: Masonry Shear Walls and Timber Braced Frames")]
        [Description("Hybrid: Masonry Shear Walls and Timber Braced Frames: Both detected.")]
        HybridMasonryShearWallsAndTimberBracedFrames,

        [DisplayText("Hybrid: Timber Shear Walls and Steel Braced Frames")]
        [Description("Hybrid: Timber Shear Walls and Steel Braced Frames: Both detected.")]
        HybridTimberShearWallsAndSteelBracedFrames,

        [DisplayText("Timber: Shear Walls and Braced Frames")]
        [Description("Timber: Shear Walls and Braced Frames: Timber walls and timber bracing both detected.")]
        TimberShearWallsAndBracedFrames,

        [DisplayText("Other: Other")]
        [Description("Other: Other: No walls or bracing, and the typical column is neither concrete nor steel (e.g. timber).")]
        Other,
    }
}
