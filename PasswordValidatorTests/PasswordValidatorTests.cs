    using Xunit;
    using PasswordValidator;

public class PasswordValidatorTests
{
    [Fact]
    public void TesteVerde()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.True(validator.SenhaForte("Senha123"));
    }
        [Fact]
        public void TesteRedSomenteNum()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.False(validator.SenhaForte("12345678"));
    }
        [Fact]
        public void TesteSomenteChar()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.False(validator.SenhaForte("abcdefg"));
    }
        [Fact]
        public void TesteVazia()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.False(validator.SenhaForte(""));
    }
        [Fact]
        public void TesteNulo()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.False(validator.SenhaForte(null));
    }
}
