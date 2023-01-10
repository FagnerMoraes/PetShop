namespace PetShop.Domain.ValueObjects;
public class Endereco
{
    public Endereco(string rua, string bairro, string numero, string cep)
    {
        Rua = rua;
        Bairro = bairro;
        Numero = numero;
        Cep = cep;
    }

    public string Rua { get; set; }
    public string Bairro { get; set; }
    public string Numero { get; set; }
    public string Cep { get; set; }
}