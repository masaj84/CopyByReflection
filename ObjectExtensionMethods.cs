using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public static class ObjectExtensionMethods
    {
        public static void GetCopyByReflection(this object source, object destination)
        {
            var srcProperties = source.GetType().GetProperties();
            var dstProperties = destination.GetType().GetProperties();
                                   
            foreach (var destinationItem in dstProperties)
            {
                foreach (var srcItem in srcProperties)
                {
                    if (srcItem.Name == destinationItem.Name && srcItem.PropertyType == destinationItem.PropertyType)
                    {
                        destinationItem.SetValue(destination, srcItem.GetValue(source));
                    }
                }
            }
        }
    }
}