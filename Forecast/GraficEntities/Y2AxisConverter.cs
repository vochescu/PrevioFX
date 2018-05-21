using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    public class Y2AxisConverter : TypeConverter
    {
        public Y2AxisConverter()
        {
        }
        // allows us to display the + symbol near the property name
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
        public override PropertyDescriptorCollection
            GetProperties(ITypeDescriptorContext context,
                object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(Y2Axis));
        }
    }
}
