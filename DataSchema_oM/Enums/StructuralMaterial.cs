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
    [Description("Material of a column or beam, as classified from the Revit model. Used by Column and Beam only.")]
    public enum StructuralMaterial
    {
        [Description("Steel - Hot Rolled: Classified as Steel or Steel Plate.")]
        SteelHotRolled,

        [Description("Steel - Light Gauge: Classified as Metal - Light Gauge, Metal Deck or Composite Metal Deck.")]
        SteelLightGauge,

        [Description("Composite: Filled, encased or SRC sections.")]
        Composite,

        [Description("Concrete - In-Situ: In-situ concrete without PT keywords.")]
        ConcreteInSitu,

        [Description("Concrete - Post Tension (PT): In-situ concrete with a PT keyword in the type name or name.")]
        ConcretePostTension,

        [Description("Concrete - Precast: Classified as precast.")]
        ConcretePrecast,

        [Description("Timber - Glulam: Glulam.")]
        TimberGlulam,

        [Description("Timber - LVL: LVL.")]
        TimberLVL,

        [Description("Timber - CLT: CLT.")]
        TimberCLT,

        [Description("Timber - Sawn: Sawn timber.")]
        TimberSawn,

        [Description("Timber - General: Timber, not more specific.")]
        TimberGeneral,

        [Description("Masonry - Concrete Blockwork: Blockwork or CMU.")]
        MasonryConcreteBlockwork,

        [Description("Masonry - Brickwork: Brick.")]
        MasonryBrickwork,

        [Description("Other: Unclassified, including stone or gabion.")]
        Other,
    }
}
