﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesCarLibrary
{
    public sealed class VehicleDescriptionAttribute : System.Attribute
    {
        public string Description { get; set; }
        public VehicleDescriptionAttribute(string vehicleDescription)
            => Description = vehicleDescription;
        public VehicleDescriptionAttribute() { }
    }
}