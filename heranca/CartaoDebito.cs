public class CartaoDebito
{
    public CartaoDebito()
    {
        //Bandeira = "Visa";
        //Bandeira = "MinhaBandeira";
        Bandeira = BandeiraCartao.Visa;
    }
    public string Numero { get; set; }
    //public string Bandeira {get; set;}
    public BandeiraCartao Bandeira { get; set; }
    public DateTime Vencimento { get; set; }
    public string Portador { get; set; }
    public string Cvv { get; set; }
}

public enum BandeiraCartao
{
    Visa,
    Mastercard,
    Amex,
    Elo
}