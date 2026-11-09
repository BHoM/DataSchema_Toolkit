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
using BH.oM.DataSchema.Enums;
using System;
using System.ComponentModel;

namespace BH.oM.DataSchema.Systems
{
    [Description("The building-level gravity (vertical load resisting) structural system, in the two vocabularies of the dashboards that use it.")]
    public class GravityStructuralSystem : BHoMObject
    {
        [DisplayText("Slab system (Building performance dashboard)")]
        [Description("Building-level slab system in the Building performance dashboard vocabulary. Derived from the typical slab type; set to Hybrid when the typical beam is a different material family from the slab. " +
                     "Missing slab data is null, not Other. " +
                     "Derivation: determine_slab_system(Slab.TypicalType, Beam.TypicalMaterial), run after apply_concrete_frame_rules. Slab type maps via BPD_slab_MAP; overridden to Hybrid: Hybrid if slab and beam material families differ. " +
                     "Edge cases: A concrete flat slab with minority steel beams is classed as hybrid. " +
                     "Aliases: frame type, floor system, structural scheme, vertical load resisting system.")]
        public virtual SlabSystemBpd? SlabSystemBpd { get; set; }

        [DisplayText("Slab system (Floor configurator)")]
        [Description("Building-level slab system in the Floor configurator vocabulary: the typical slab type combined with the typical supporting beam material. " +
                     "Missing slab data is null. " +
                     "Derivation: determine_slab_system(Slab.TypicalType, Beam.TypicalMaterial): keyword rules on slab type first, then beam material for precast and timber slabs. " +
                     "Edge cases: All in-situ concrete slabs become Flat Slab, including beam-and-slab schemes. Composite deck is always on Steel Beams, even if the typical beam is timber or concrete. " +
                     "Aliases: frame type, floor system, structural scheme, vertical load resisting system.")]
        public virtual SlabSystemFc? SlabSystemFc { get; set; }
    }
}
