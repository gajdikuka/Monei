using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_teszt.Validation
{
    class RequiredValidation
    {
        public static bool IsValid(string value)
        {
            return !string.IsNullOrEmpty(value);
        }
    }
}
