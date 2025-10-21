using PasswordValidationLibrary;

namespace PasswordValidatorTests
{
    public class PasswordValidationModuleTest
    {
        [Theory]
        [InlineData("Password1", true)]
        [InlineData("qwe123", false)]
        [InlineData("Password", false)]
        [InlineData("12341234", false)]
        [InlineData("", false)]
        [InlineData(null, true)]
        [InlineData("Пароль1234", true)]
        public void ValidatePassword_VariousInputs_ReturnsExpectedResults(string password, bool expected)
        {
            bool result = PasswordValidator.ValidatePassword(password);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ValidatePassword_WithValidPassword_ReturnsTrue()
        {
            string validPassword = "Qwerty123";

            bool result = PasswordValidator.ValidatePassword(validPassword);

            Assert.True(result);
        }

        [Fact]
        public void ValidatePassword_WithValidPassword_ReturnsFalse()
        {
            string invalidPassword = "qwe";

            bool result = PasswordValidator.ValidatePassword(invalidPassword);
            
            Assert.False(result);
        }
    }
}