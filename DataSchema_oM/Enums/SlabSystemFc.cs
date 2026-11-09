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
    [Description("Building-level slab system, in the vocabulary of the Floor configurator: the typical slab type combined with the typical supporting beam material.")]
    public enum SlabSystemFc
    {
        [DisplayText("Post Tensioned Concrete: PT Flat Slab")]
        [Description("Post Tensioned Concrete: PT Flat Slab: Typical slab is PT (any beam).")]
        PostTensionedConcretePTFlatSlab,

        [DisplayText("Steel: Composite Metal Deck on Steel Beams")]
        [Description("Steel: Composite Metal Deck on Steel Beams: Typical slab is Composite Metal Deck (any beam).")]
        SteelCompositeMetalDeckOnSteelBeams,

        [DisplayText("Hybrid: Hollowcore Slab on Steel Beams")]
        [Description("Hybrid: Hollowcore Slab on Steel Beams: Precast hollowcore slab; steel beams.")]
        HybridHollowcoreSlabOnSteelBeams,

        [DisplayText("Hybrid: Hollowcore Slab on Glulam Beams")]
        [Description("Hybrid: Hollowcore Slab on Glulam Beams: Precast hollowcore slab; glulam or timber beams.")]
        HybridHollowcoreSlabOnGlulamBeams,

        [DisplayText("Precast Concrete: Hollowcore Slab on Concrete Beams")]
        [Description("Precast Concrete: Hollowcore Slab on Concrete Beams: Precast hollowcore slab; any other beam, including unknown.")]
        PrecastConcreteHollowcoreSlabOnConcreteBeams,

        [DisplayText("Timber: CLT Slab on Glulam Beams")]
        [Description("Timber: CLT Slab on Glulam Beams: CLT slab; glulam or timber beams, or beam unknown (default).")]
        TimberCLTSlabOnGlulamBeams,

        [DisplayText("Hybrid: CLT Slab on Steel Beams")]
        [Description("Hybrid: CLT Slab on Steel Beams: CLT slab; steel beams.")]
        HybridCLTSlabOnSteelBeams,

        [DisplayText("Hybrid: CLT Slab on Concrete Beams")]
        [Description("Hybrid: CLT Slab on Concrete Beams: CLT slab; concrete or precast beams.")]
        HybridCLTSlabOnConcreteBeams,

        [DisplayText("Timber: LVL Slab on Glulam Beams")]
        [Description("Timber: LVL Slab on Glulam Beams: LVL slab; glulam or timber beams, or beam unknown (default).")]
        TimberLVLSlabOnGlulamBeams,

        [DisplayText("Hybrid: LVL Slab on Steel Beams")]
        [Description("Hybrid: LVL Slab on Steel Beams: LVL slab; steel beams.")]
        HybridLVLSlabOnSteelBeams,

        [DisplayText("Hybrid: LVL Slab on Concrete Beams")]
        [Description("Hybrid: LVL Slab on Concrete Beams: LVL slab; concrete or precast beams.")]
        HybridLVLSlabOnConcreteBeams,

        [DisplayText("Timber: Timber Slab on Glulam Beams")]
        [Description("Timber: Timber Slab on Glulam Beams: General timber slab; timber beams, or beam unknown (default).")]
        TimberTimberSlabOnGlulamBeams,

        [DisplayText("Hybrid: Timber Slab on Steel Beams")]
        [Description("Hybrid: Timber Slab on Steel Beams: General timber slab; steel beams.")]
        HybridTimberSlabOnSteelBeams,

        [DisplayText("Hybrid: Timber Slab on Concrete Beams")]
        [Description("Hybrid: Timber Slab on Concrete Beams: General timber slab; concrete or precast beams.")]
        HybridTimberSlabOnConcreteBeams,

        [DisplayText("In Situ Concrete: Flat Slab")]
        [Description("In Situ Concrete: Flat Slab: Any non-precast concrete slab (any beam).")]
        InSituConcreteFlatSlab,

        [DisplayText("Steel: Metal Deck on Steel Beams")]
        [Description("Steel: Metal Deck on Steel Beams: Non-composite metal deck (any beam).")]
        SteelMetalDeckOnSteelBeams,

        [DisplayText("Steel: Steel Plate")]
        [Description("Steel: Steel Plate: Steel plate floor.")]
        SteelSteelPlate,

        [DisplayText("Other: Other")]
        [Description("Other: Other: Slab type identified but not mapped. Missing slab data is null.")]
        Other,
    }
}
