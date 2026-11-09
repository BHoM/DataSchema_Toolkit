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
using BH.oM.DataSchema.Enums;
using System;
using System.ComponentModel;

namespace BH.oM.DataSchema.Elements
{
    [Description("The suspended floor slabs of a building: typical type and depth, and the type of the ground slab.")]
    public class Slab : BaseStructuralElement
    {
        [DisplayText("Ground slab type")]
        [Description("Whether the lowest slab in the building bears on the ground or is suspended. Where there is a basement, this is the basement slab. " +
                     "Derivation: Find the lowest merged level with slabs and search the slab names and type names. Suspended Slab if the name contains suspended and no ground-slab keyword; otherwise Ground Bearing. Without merged levels, the code works up the raw levels looking for ground or grade (Ground Bearing) or suspended (Suspended Slab). " +
                     "Edge cases: Defaults to Ground Bearing unless named suspended, so suspended slabs with unclear names are misclassified; 18 of 19 projects are Ground Bearing. With a basement, this describes the basement slab, not the ground floor. Raft foundations acting as the ground slab are recorded as Ground Bearing. " +
                     "Aliases: ground floor slab.")]
        public virtual GroundSlabType? GroundType { get; set; }

        [DisplayText("Typical slab depth")]
        [Description("Depth of the typical suspended floor slab: concrete topping depth above the deck for composite metal deck; overall slab thickness for all other types. " +
                     "Derivation: Taken from the typical type name. The first number is read; its unit comes from the suffix (mm, in) or, without a suffix, numbers under 25 are taken as inches. Rounded to 5 mm. " +
                     "Edge cases: Composite types named with one number (e.g. 130 THK COMPOSITE METAL DECK) usually give overall depth, not topping; the code returns 130. Composite topping depths are not comparable with the overall thickness of other slab types. " +
                     "Aliases: slab thickness, slab depth, topping depth for composite.")]
        [Length]
        public virtual double? TypicalTypeDepth { get; set; }
    }
}
