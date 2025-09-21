    using Xunit;
    using PasswordValidator;

public class PasswordValidatorTests
{
    //Testando Verde
    [Fact]
    public void TesteVerde()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.True(validator.SenhaForte("Senha123"));
    }
    //Testando somente com números
    [Fact]
    public void TesteOitoNum()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.True(validator.SenhaForte("12345678"));
    }
    //Testando somente com caracteres
    [Fact]
    public void TesteSeteChar()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.False(validator.SenhaForte("abcdefg"));
    }
    //Testando com a String vazia
    [Fact]
    public void TesteVazia()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.False(validator.SenhaForte(""));
    }
    //Testando Null
    [Fact]
    public void TesteNulo()
    {
        var validator = new PasswordValidator.PasswordValidator();
        Assert.False(validator.SenhaForte(null));
    }
}
