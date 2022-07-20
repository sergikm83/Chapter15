using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesCarLibrary
{
    // На этот раз для аннотирования специального атрибута
    // мы используем атрибут AttributeUsage.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
    public sealed class VehicleDescriptionAttribute : System.Attribute
    {
        public string Description { get; set; }
        public VehicleDescriptionAttribute(string vehicleDescription)
            => Description = vehicleDescription;
        public VehicleDescriptionAttribute() { }
    }
}
