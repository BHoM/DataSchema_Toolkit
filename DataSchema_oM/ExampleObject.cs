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
using BH.oM.DataSchema;
using BH.oM.DataSchema.Enums;
using BH.oM.Quantities.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BH.oM.Adapters.DataSchema
{
    [Description("Example object for demonstrating the C# to Python conversion: one property for each kind of type that the conversion supports.")]
    public class ExampleObject : BHoMObject
    {
        // Scalars

        [Description("A text. Becomes a nullable string in Python, since a string can be null in C#.")]
        public virtual string SomeStringProperty { get; set; }

        [Description("A whole number. Becomes an int in Python.")]
        public virtual int SomeNumberProperty { get; set; }

        [Description("A number with a decimal part. Becomes a float in Python.")]
        public virtual double SomeDecimalNumber { get; set; } = 1.5;

        [Description("A true or false value.")]
        public virtual bool IsActive { get; set; } = true;

        [Description("An exact decimal value, for money for example. Becomes a Decimal in Python.")]
        public virtual decimal Cost { get; set; } = 10.25m;

        [Description("A single character. Becomes a one-letter str in Python.")]
        public virtual char Letter { get; set; } = 'x';

        [Description("A date and time. Becomes a datetime in Python.")]
        public virtual DateTime CreatedOn { get; set; } = new DateTime(2020, 1, 2, 3, 4, 5);

        [Description("A length of time. Becomes a timedelta in Python.")]
        public virtual TimeSpan Duration { get; set; } = TimeSpan.FromMinutes(90);

        [Description("A unique identifier. Becomes a UUID in Python.")]
        public virtual Guid ExternalId { get; set; } = Guid.Empty;

        // Optional values

        [Description("A whole number that can be missing. Becomes int | None in Python.")]
        public virtual int? OptionalCount { get; set; }

        [Description("A number that can be missing. Becomes float | None in Python.")]
        public virtual double? OptionalRatio { get; set; }

        // Attributes

        [DisplayText("Span length")]
        [Length]
        [Description("A length in metres. The display text and the unit travel with the property to Python.")]
        public virtual double SpanLength { get; set; } = 6.0;

        // Enums

        [Description("A choice from a list of allowed values. Python refuses a value that is not a member.")]
        public virtual ExampleStatus Status { get; set; } = ExampleStatus.Draft;

        [Description("A choice that can be missing.")]
        public virtual StructuralMaterial? Material { get; set; }

        [Description("A combination of values from a list, written as a comma-separated text such as 'Painted, Insulated'.")]
        public virtual ExampleFinish Finish { get; set; } = ExampleFinish.None;

        // Collections

        [Description("A list of texts (named Labels because every BHoM object already has Tags).")]
        public virtual List<string> Labels { get; set; } = new List<string>();

        [Description("An array of numbers. Becomes a list of floats in Python.")]
        public virtual double[] Values { get; set; } = new double[0];

        [Description("A list of lists of whole numbers, such as a matrix.")]
        public virtual List<List<int>> Matrix { get; set; } = new List<List<int>>();

        [Description("A set of unique texts. Becomes a set in Python.")]
        public virtual HashSet<string> UniqueNames { get; set; } = new HashSet<string>();

        [Description("A dictionary with text keys.")]
        public virtual Dictionary<string, double> Lookup { get; set; } = new Dictionary<string, double>();

        [Description("A dictionary with an enum as the key. Written as a list of key and value objects in JSON.")]
        public virtual Dictionary<ExampleStatus, double> TotalsByStatus { get; set; } = new Dictionary<ExampleStatus, double>();

        [Description("A pair of values of different types.")]
        public virtual Tuple<int, string> Pair { get; set; }

        // Other objects

        [Description("Another object, held inside this one.")]
        public virtual Grid MainGrid { get; set; }

        [Description("A list of other objects.")]
        public virtual List<Storey> Storeys { get; set; } = new List<Storey>();

        [Description("Any object of a type that implements IObject, whatever its class. Python reads and writes the class of each one.")]
        public virtual IObject Anything { get; set; }

        [Description("A value of any type. Becomes Any in Python.")]
        public virtual object Extra { get; set; }
    }
}
