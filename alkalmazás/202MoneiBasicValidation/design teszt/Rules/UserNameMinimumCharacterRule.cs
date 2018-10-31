using System.Globalization;
using System.Windows.Controls;

namespace design_teszt.Rules
{
    public class UserNameMinimumCharacterRule : ValidationRule
    {
        public int UserNameMinimumCharacter { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string charString = value as string;
            if(charString.Length < UserNameMinimumCharacter || charString.Length == 0)
            {
                return new ValidationResult(false, $"A felhasználó név nem lehet üres és minimum {UserNameMinimumCharacter} hosszúnak kell lennie!");
            }
            return new ValidationResult(true, null);
        }
    }
}
