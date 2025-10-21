namespace PasswordValidationLibrary
{
    public static class PasswordValidator
    {
        public static bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            if (password.Length < 8)
                return false;

            if (!password.Any(char.IsDigit)) 
                return false;
            
            if (!password.Any(c => IsLatinLetter(c))) 
                return false;

            return true;
        }

        //public static bool ValidatePasswordModul(string password)
        //{
        //    if (!ValidatePassword(password)) 
        //        return false;

        //    if (!password.Any(char.IsUpper)) 
        //        return false;

        //    if (!password.Any(char.IsLower))
        //        return false;

        //    if (!password.Any(c => IsSpecialCharacter(c)))
        //        return false;

        //    return true;
        //}

        private static bool IsLatinLetter(char c) 
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        //private static bool IsSpecialCharacter(char c)
        //{
        //    string specialCharacters = "!@#$%&*()?_-";
        //    return specialCharacters.Contains(c);
        //}
    }
}
