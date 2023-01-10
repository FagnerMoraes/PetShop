
namespace PetShop.Domain.ValueObjects;

public class Nome
{
    public Nome(string primeiroNome, string sobrenome)
    {
        PrimeiroNome = primeiroNome;
        Sobrenome = sobrenome;
    }

    public string PrimeiroNome { get; set; }
    public string Sobrenome { get; set; }

    public override string ToString()
    {
        return $"{PrimeiroNome} {Sobrenome}";
    }
}
