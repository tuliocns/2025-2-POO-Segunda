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

    public bool Debitar(decimal valor)
    {
        if (valor > Saldo)
            return false;

        Saldo -= valor;
        return true;
    }

    public bool Debitar(decimal valor, bool Debitar)
    {
        if (valor <= (Saldo + valor))
            return true;
        
    }

}

public enum BandeiraCartao
{
    Visa,
    Mastercard,
    Amex,
    Elo
}