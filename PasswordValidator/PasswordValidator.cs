namespace PasswordValidator;

public class PasswordValidator
{
    public bool SenhaForte(string senha) {
        if (string.IsNullOrEmpty(senha)){
            return false;
        }
        if (senha.Length < 8){
            return false;
        }
        return TemTamanho(senha);
    }
    private bool TemTamanho(string senha){
        return senha.Length >= 8;
    }
}
