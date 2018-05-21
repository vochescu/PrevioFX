using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast
{
    public class XYLabelConverter : TypeConverter
    {
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context,
                object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(XYLabel));
        }
    }
}
