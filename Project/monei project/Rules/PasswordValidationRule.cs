using System.Globalization;
using System.Linq;
using System.Windows.Controls;

namespace monei_project.Rules
{
    public class PasswordValidationRule : ValidationRule
    {
        public int PasswordMinimumCharacter { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string charString = value as string;
            if (PasswordIsValid(charString))
            {
                return new ValidationResult(true, null);
            }
            return new ValidationResult(false, "A jelszó nem lehet üres és {PasswordMinimumCharacter} hosszúnak kell lennie!, tartalmaznia kell számot és kis/nagy betűt");
        }

        private bool PasswordIsValid(string charString)
        {
            return charString.Any(char.IsDigit) && !(charString.Length < PasswordMinimumCharacter || charString.Length == 0) && charString.Any(char.IsUpper);
        }
    }
}
