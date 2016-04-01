using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Enum 
        | AttributeTargets.Method | AttributeTargets.Interface)]

    internal class VersionAttribute : System.Attribute
    {
        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major { get; set; }
        public int Minor { get; set; }
    }
}
