using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.TypeDescriptor;

namespace Forecast
{
    public class YAxisConverter : TypeConverter
    {
        public YAxisConverter()
        {
        }
        // allows us to display the + symbol near the property name
        public override bool GetPropertiesSupported(
            ITypeDescriptorContext context)
        {
            return true;
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context,
                object value, Attribute[] attributes)
        { 
            return TypeDescriptor.GetProperties(typeof(YAxis));
        }
    }
}
