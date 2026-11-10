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
    [Description("Predominant system or type of a slab, a roof or a foundation. The slab types are used by Slab and Roof; the foundation types by PileFoundation.")]
    public enum StructuralElementType
    {
        [Description("Concrete - Flat Slab: Slab and Roof: in-situ concrete slab (any form).")]
        ConcreteFlatSlab,

        [Description("Concrete - Post Tension (PT): Slab and Roof: concrete slab with a PT keyword.")]
        ConcretePostTension,

        [Description("Precast Concrete - Hollowcore Slab: Slab and Roof: precast slab.")]
        PrecastConcreteHollowcoreSlab,

        [Description("Composite Metal Deck: Slab and Roof: deck with concrete topping.")]
        CompositeMetalDeck,

        [Description("Metal Deck: Slab and Roof: deck without topping.")]
        MetalDeck,

        [Description("Steel Plate: Slab and Roof: steel plate floor.")]
        SteelPlate,

        [Description("Timber - CLT Slab: Slab and Roof: CLT.")]
        TimberCLTSlab,

        [Description("Timber - LVL Slab: Slab and Roof: LVL.")]
        TimberLVLSlab,

        [Description("Timber - General: Slab and Roof: other timber, including glulam-classified slabs.")]
        TimberGeneral,

        [Description("Masonry - Concrete Blockwork: Slab and Roof: blockwork.")]
        MasonryConcreteBlockwork,

        [Description("Masonry - Brickwork: Slab and Roof: brick.")]
        MasonryBrickwork,

        [Description("Concrete: Pad/Footing: PileFoundation: no piles or raft; mainly concrete.")]
        FoundationConcretePadFooting,

        [Description("Concrete: Piles and Caps: PileFoundation: concrete piles, no raft.")]
        FoundationConcretePilesAndCaps,

        [Description("Concrete Piled Raft: PileFoundation: concrete piles with a raft.")]
        FoundationConcretePiledRaft,

        [Description("Concrete: Raft/Mat Slab: PileFoundation: raft or mat, no piles.")]
        FoundationConcreteRaftMatSlab,

        [Description("Steel: Driven Piles: PileFoundation: piles mainly steel.")]
        FoundationSteelDrivenPiles,

        [Description("Timber: Driven Piles: PileFoundation: piles mainly timber.")]
        FoundationTimberDrivenPiles,

        [Description("Stone: Vibro Columns: PileFoundation: vibro or stone column keywords.")]
        FoundationStoneVibroColumns,

        [Description("Stone: Blocks: PileFoundation: stone or block keywords.")]
        FoundationStoneBlocks,

        [Description("Other: Slab, Roof and PileFoundation: unclassified, or none of the above.")]
        Other,
    }
}
