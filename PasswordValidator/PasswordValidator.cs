namespace PasswordValidator;

public class PasswordValidator
{
    public bool SenhaForte(string senha) {
        return !string.IsNullOrEmpty(senha) && TemTamanho(senha);
    }
    private bool TemTamanho(string senha) => senha.Length >= 8;
    
}
