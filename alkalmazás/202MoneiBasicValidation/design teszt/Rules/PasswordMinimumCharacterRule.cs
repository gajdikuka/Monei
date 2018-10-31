using System.Globalization;
using System.Windows.Controls;

namespace design_teszt.Rules
{
    public class PasswordMinimumCharacterRule : ValidationRule
    {
        public int PasswordMinimumCharacter { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string charString = value as string;
            if (charString.Length < PasswordMinimumCharacter || charString.Length == 0)
            {
                return new ValidationResult(false, $"A jelszó nem lehet üres és {PasswordMinimumCharacter} hosszúnak kell lennie!");
            }
            return new ValidationResult(true, null);
        }
    }
}
