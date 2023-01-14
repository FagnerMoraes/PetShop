namespace PetShop.Domain.ValueObjects;
public class Adress
{
    public Adress(string street, string district, string houseNumber, string zipCode)
    {
        Street = street;
        District = district;
        HouseNumber = houseNumber;
        ZipCode = zipCode;
    }

    public string Street { get; set; }
    public string District { get; set; }
    public string HouseNumber { get; set; }
    public string ZipCode { get; set; }
}