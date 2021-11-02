using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ji.Base
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ValidateAPIAttribute : Attribute
    {
        public ValidateAPIAttribute(bool authen)
        {
            
        }
    }
}
