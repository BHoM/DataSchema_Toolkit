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

using System.ComponentModel;

namespace BH.oM.DataSchema.Enums
{
    [Description("Type of a slab, used as the key of the material distribution of Slab.")]
    public enum SlabType
    {
        [Description("Concrete - Flat Slab: In-situ concrete slab (any form).")]
        ConcreteFlatSlab,

        [Description("Concrete - Post Tension (PT): Concrete slab with a PT keyword.")]
        ConcretePostTension,

        [Description("Precast Concrete - Hollowcore Slab: Precast slab.")]
        PrecastConcreteHollowcoreSlab,

        [Description("Composite Metal Deck: Deck with concrete topping.")]
        CompositeMetalDeck,

        [Description("Metal Deck: Deck without topping.")]
        MetalDeck,

        [Description("Steel Plate: Steel plate floor.")]
        SteelPlate,

        [Description("Timber - CLT Slab: CLT.")]
        TimberCLTSlab,

        [Description("Timber - LVL Slab: LVL.")]
        TimberLVLSlab,

        [Description("Timber - General: Other timber, including glulam-classified slabs.")]
        TimberGeneral,

        [Description("Masonry - Concrete Blockwork: Blockwork.")]
        MasonryConcreteBlockwork,

        [Description("Masonry - Brickwork: Brick.")]
        MasonryBrickwork,

        [Description("Other: Unclassified.")]
        Other,
    }
}
