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
    [Description("Predominant system or type of a slab, a roof or a foundation. The slab types are used by Slab and Roof; the foundation types by PileFoundation.")]
    public enum StructuralElementType
    {
        [DisplayText("Concrete - Flat Slab")]
        [Description("Concrete - Flat Slab: Slab and Roof: in-situ concrete slab (any form).")]
        ConcreteFlatSlab,

        [DisplayText("Concrete - Post Tension (PT)")]
        [Description("Concrete - Post Tension (PT): Slab and Roof: concrete slab with a PT keyword.")]
        ConcretePostTension,

        [DisplayText("Precast Concrete - Hollowcore Slab")]
        [Description("Precast Concrete - Hollowcore Slab: Slab and Roof: precast slab.")]
        PrecastConcreteHollowcoreSlab,

        [DisplayText("Composite Metal Deck")]
        [Description("Composite Metal Deck: Slab and Roof: deck with concrete topping.")]
        CompositeMetalDeck,

        [DisplayText("Metal Deck")]
        [Description("Metal Deck: Slab and Roof: deck without topping.")]
        MetalDeck,

        [DisplayText("Steel Plate")]
        [Description("Steel Plate: Slab and Roof: steel plate floor.")]
        SteelPlate,

        [DisplayText("Timber - CLT Slab")]
        [Description("Timber - CLT Slab: Slab and Roof: CLT.")]
        TimberCLTSlab,

        [DisplayText("Timber - LVL Slab")]
        [Description("Timber - LVL Slab: Slab and Roof: LVL.")]
        TimberLVLSlab,

        [DisplayText("Timber - General")]
        [Description("Timber - General: Slab and Roof: other timber, including glulam-classified slabs.")]
        TimberGeneral,

        [DisplayText("Masonry - Concrete Blockwork")]
        [Description("Masonry - Concrete Blockwork: Slab and Roof: blockwork.")]
        MasonryConcreteBlockwork,

        [DisplayText("Masonry - Brickwork")]
        [Description("Masonry - Brickwork: Slab and Roof: brick.")]
        MasonryBrickwork,

        [DisplayText("Concrete: Pad/Footing")]
        [Description("Concrete: Pad/Footing: PileFoundation: no piles or raft; mainly concrete.")]
        FoundationConcretePadFooting,

        [DisplayText("Concrete: Piles and Caps")]
        [Description("Concrete: Piles and Caps: PileFoundation: concrete piles, no raft.")]
        FoundationConcretePilesAndCaps,

        [DisplayText("Concrete Piled Raft")]
        [Description("Concrete Piled Raft: PileFoundation: concrete piles with a raft.")]
        FoundationConcretePiledRaft,

        [DisplayText("Concrete: Raft/Mat Slab")]
        [Description("Concrete: Raft/Mat Slab: PileFoundation: raft or mat, no piles.")]
        FoundationConcreteRaftMatSlab,

        [DisplayText("Steel: Driven Piles")]
        [Description("Steel: Driven Piles: PileFoundation: piles mainly steel.")]
        FoundationSteelDrivenPiles,

        [DisplayText("Timber: Driven Piles")]
        [Description("Timber: Driven Piles: PileFoundation: piles mainly timber.")]
        FoundationTimberDrivenPiles,

        [DisplayText("Stone: Vibro Columns")]
        [Description("Stone: Vibro Columns: PileFoundation: vibro or stone column keywords.")]
        FoundationStoneVibroColumns,

        [DisplayText("Stone: Blocks")]
        [Description("Stone: Blocks: PileFoundation: stone or block keywords.")]
        FoundationStoneBlocks,

        [DisplayText("Other")]
        [Description("Other: Slab, Roof and PileFoundation: unclassified, or none of the above.")]
        Other,
    }
}
