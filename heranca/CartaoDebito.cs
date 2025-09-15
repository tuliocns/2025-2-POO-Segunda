public class CartaoDebito
{
    public CartaoDebito()
    {
        Bandeira = "Visa";
        Bandeira = "MinhaBandeira";
        Bandeira = BandeiraCartao.Visa;
    }
    public string Numero {get; set;}
    public string Bandeira {get; set;}
}

public enum BandeiraCartao
{
    Visa,
    Mastercard,
    Amex,
    Elo
}