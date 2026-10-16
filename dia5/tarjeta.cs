Tarjeta tarjeta = new Tarjeta("Lucia");

tarjeta.Recargar(-5);
tarjeta.Recargar(20000);
tarjeta.Pagar(10000);
tarjeta.Pagar(10000);
tarjeta.Pagar(1000);




class Tarjeta
{
    private int _saldo ;
    public string Titular;

    
    public int Saldo
    {
        get{return _saldo;}
    }
    public Tarjeta(string titular)
    {
        Titular = titular;
    }

    public void Recargar (int monto)
    {
        if (monto < 0)
        {
            Console.WriteLine("La recarga ("+ monto +") debe ser mayor a cero");
        }
        else
        {
            Console.WriteLine("Recargar: "+monto);
            _saldo += monto;            
        }
        
    }
    public bool Pagar(int monto)
    {
        Console.WriteLine("Pagar: "+monto);

        if (monto > _saldo)
        {
            Console.WriteLine("Saldo insuficiente");
            return false;
        }
        else
        {
            Console.WriteLine("Pago exitoso");
            _saldo -= monto;
            return true;    
        }        
        
    }

}