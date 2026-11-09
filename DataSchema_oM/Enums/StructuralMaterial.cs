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
    [Description("Material of a column or beam, as classified from the Revit model. Used by Column and Beam only.")]
    public enum StructuralMaterial
    {
        [DisplayText("Steel - Hot Rolled")]
        [Description("Steel - Hot Rolled: Classified as Steel or Steel Plate.")]
        SteelHotRolled,

        [DisplayText("Steel - Light Gauge")]
        [Description("Steel - Light Gauge: Classified as Metal - Light Gauge, Metal Deck or Composite Metal Deck.")]
        SteelLightGauge,

        [DisplayText("Composite")]
        [Description("Composite: Filled, encased or SRC sections.")]
        Composite,

        [DisplayText("Concrete - In-Situ")]
        [Description("Concrete - In-Situ: In-situ concrete without PT keywords.")]
        ConcreteInSitu,

        [DisplayText("Concrete - Post Tension (PT)")]
        [Description("Concrete - Post Tension (PT): In-situ concrete with a PT keyword in the type name or name.")]
        ConcretePostTension,

        [DisplayText("Concrete - Precast")]
        [Description("Concrete - Precast: Classified as precast.")]
        ConcretePrecast,

        [DisplayText("Timber - Glulam")]
        [Description("Timber - Glulam: Glulam.")]
        TimberGlulam,

        [DisplayText("Timber - LVL")]
        [Description("Timber - LVL: LVL.")]
        TimberLVL,

        [DisplayText("Timber - CLT")]
        [Description("Timber - CLT: CLT.")]
        TimberCLT,

        [DisplayText("Timber - Sawn")]
        [Description("Timber - Sawn: Sawn timber.")]
        TimberSawn,

        [DisplayText("Timber - General")]
        [Description("Timber - General: Timber, not more specific.")]
        TimberGeneral,

        [DisplayText("Masonry - Concrete Blockwork")]
        [Description("Masonry - Concrete Blockwork: Blockwork or CMU.")]
        MasonryConcreteBlockwork,

        [DisplayText("Masonry - Brickwork")]
        [Description("Masonry - Brickwork: Brick.")]
        MasonryBrickwork,

        [DisplayText("Other")]
        [Description("Other: Unclassified, including stone or gabion.")]
        Other,
    }
}
