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
    [Description("Building-level slab system, in the vocabulary of the Building performance dashboard.")]
    public enum SlabSystemBpd
    {
        [DisplayText("Steel: Hot Rolled Steel")]
        [Description("Steel: Hot Rolled Steel: Typical slab is Composite Metal Deck or Steel Plate, with beams of the same family.")]
        SteelHotRolledSteel,

        [DisplayText("Steel: Light Gauge Steel")]
        [Description("Steel: Light Gauge Steel: Typical slab is non-composite Metal Deck.")]
        SteelLightGaugeSteel,

        [DisplayText("Concrete: In-Situ")]
        [Description("Concrete: In-Situ: Typical slab is Concrete - Flat Slab (any in-situ concrete slab).")]
        ConcreteInSitu,

        [DisplayText("Concrete: Post Tension (PT)")]
        [Description("Concrete: Post Tension (PT): Typical slab is Concrete - Post Tension (PT).")]
        ConcretePostTension,

        [DisplayText("Concrete: Precast")]
        [Description("Concrete: Precast: Typical slab is Precast Concrete - Hollowcore Slab.")]
        ConcretePrecast,

        [DisplayText("Timber: Engineered Timber")]
        [Description("Timber: Engineered Timber: Typical slab is CLT or LVL.")]
        TimberEngineeredTimber,

        [DisplayText("Timber: Softwood/Hardwood")]
        [Description("Timber: Softwood/Hardwood: Typical slab is Timber - General (includes glulam-classified slabs).")]
        TimberSoftwoodHardwood,

        [DisplayText("Masonry: Concrete Blockwork")]
        [Description("Masonry: Concrete Blockwork: Typical slab is Masonry - Concrete Blockwork.")]
        MasonryConcreteBlockwork,

        [DisplayText("Masonry: Brickwork")]
        [Description("Masonry: Brickwork: Typical slab is Masonry - Brickwork.")]
        MasonryBrickwork,

        [DisplayText("Hybrid: Hybrid")]
        [Description("Hybrid: Hybrid: Slab and typical beam are in different material families (steel, concrete, timber or masonry).")]
        Hybrid,

        [DisplayText("Other: Other")]
        [Description("Other: Other: Slab type identified but not mapped. Missing slab data is null, not Other.")]
        Other,
    }
}
