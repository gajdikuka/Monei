using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace monei_project.Rules
{
    public class CantBeNullRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string charString = value as string;
            if (charString != null)
            {
                if (charString.Length == 0)
                {
                    return new ValidationResult(false, "A mező nem lehet üres");
                }
                return new ValidationResult(true, null);
            }
            else
                return new ValidationResult(false, "NullObject");

        }
    }
}
