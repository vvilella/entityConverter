using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace entityConverter.CustomAttribute
{
    [System.AttributeUsage(System.AttributeTargets.Property,
                   AllowMultiple = true)]
    public class ProperyEntityAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
