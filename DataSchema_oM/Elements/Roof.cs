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
    [Description("The roof slabs of a building: typical type and depth.")]
    public class Roof : BaseStructuralElement
    {
        [DisplayText("Typical roof slab depth")]
        [Description("Depth of the typical roof slab: concrete topping depth for composite metal deck, overall thickness otherwise. Taken from the type name covering the largest area at or above the roof level. " +
                     "Derivation: Taken from the typical type name. The first number is read; its unit comes from the suffix (mm, in) or, without a suffix, numbers under 25 are taken as inches. Rounded to 5 mm. For composite types with two numbers, the first is the topping. " +
                     "Edge cases: Can pick up transfer, podium or landscaped roof slabs much deeper than the typical floor. Bare metal deck roofs return the deck depth. A roof area can exist with no readable depth. " +
                     "Aliases: roof slab thickness, roof depth.")]
        [Length]
        public virtual double? TypicalTypeDepth { get; set; }
    }
}
