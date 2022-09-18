namespace ExemploAspNetMvc.Models;

public class User
{
    public string Nome { get; set; }
    public string Senha { get; set; }
    public string Email { get; set; }

    public User( string nome, string senha, string email)
    {
        Nome = nome;
        Senha = senha;
        Email = email;
    }

}