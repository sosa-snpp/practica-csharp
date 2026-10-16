Cliente cliente = new Cliente("EN","46546");
Prestamo prestamo = new Prestamo(cliente,6000000,12,2);
prestamo.Mostrar();
prestamo.PagarCuota();
prestamo.PagarCuota();
prestamo.Mostrar();

class Cliente
{
    public string Nombre {get;}
    public string Cedula {get;}
    public Cliente(string nombre,string cedula)
    {
        Nombre = nombre!;
        Cedula = cedula!;
        Console.WriteLine("Cliente Nuevo Creado");
        ImprimirDatos();

    }
    public void ImprimirDatos()
    {
        Console.WriteLine("===========================");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Cedula: {Cedula}");
        Console.WriteLine("===========================");
    }
}

class Prestamo
{
    public Cliente Titular{get;}
    public double Monto {get;}
    public int Cuotas{get;}
    public double TasaMensual{get;}

    public int CuotasPagadas {get;private set;}

    public Prestamo(Cliente titular,double monto,int cuotas,double tasaMensual)
    {
        Titular = titular;
        Monto = monto;
        Cuotas = cuotas;
        TasaMensual = tasaMensual;
        CuotasPagadas = 0;     
        Console.WriteLine("===========================");
        Console.WriteLine("Prestamo creado:");
        Console.WriteLine($"Titular: {Titular.Nombre}");
        Console.WriteLine($"Monto: {Monto}");
        Console.WriteLine($"Tasa: {TasaMensual}");
        Console.WriteLine("===========================");      

    }

    public double CalcularCuota()
    {
        double interesTotal = Monto * TasaMensual / 100 *Cuotas;
        return Math.Round((Monto+interesTotal)/Cuotas);
    }

    public double SaldoPendiente()
    {
        return (CalcularCuota()*(Cuotas-CuotasPagadas));
    }
    public void PagarCuota()
    {
        if (CuotasPagadas < Cuotas)
        {
            CuotasPagadas ++;
            Console.WriteLine("Pago exitoso");
        }
        else
        {
            Console.WriteLine("No hay nada que pagar");
        }
    }
    public void Mostrar()    
    {
        Console.WriteLine("===========================");
        Console.WriteLine("Datos del préstamo:");
        Console.WriteLine($"Titular: {Titular.Nombre} CI: {Titular.Cedula}");
        Console.WriteLine($"Cuota: {CalcularCuota().ToString("N0")} Gs. Pagadas: { CuotasPagadas } de {Cuotas}");
        Console.WriteLine($"Saldo pendiente: {SaldoPendiente().ToString("N0")} Gs.");
        Console.WriteLine("===========================");
    }
}


