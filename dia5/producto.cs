List<Producto> inventario = new List<Producto>();

inventario.Add(new Producto("K001","Gaseosa 500ml",6000,24,6));
inventario.Add(new Producto("K002","Alfajor",3500,40,10));
inventario.Add(new Producto("K003","Agua mineral 1L",4500,8,6));

inventario[0].Vender(24);
inventario[0].NecesitaReposicion();

Console.WriteLine("=== Inventario del Kiosko ===");

foreach (Producto p in inventario)
{
    p.Mostrar();
}




class Producto
{
    private int _stock;
    private double _precioVenta;
    public string Codigo {get;}
    public string Nombre {get;}
    public int StockMinimo {get;}
    public double PrecioVenta
    {
        get 
        {
            return _precioVenta;
        }
        set
        {
            if (value > 0)
            {
                _precioVenta = value;
            }
        }
    }
    public int Stock
    {
        get 
        {
            return _stock;
        }
    }

    public Producto(string codigo,string nombre,double precioVenta,int stock,int stockMinimo)
    {
        Codigo = codigo;
        Nombre = nombre;
        PrecioVenta = precioVenta;
        _stock = stock;
        StockMinimo = stockMinimo;
        Console.WriteLine("=========== CREAR PRODUCTO ==========");        
        Console.WriteLine($"Producto creado {Codigo} - {Nombre}");        
        
    }

    public bool Vender(int cantidad)
    {
        if (cantidad <= 0 ||cantidad>_stock)
        {   Console.WriteLine("============= VENTA =============");
            Console.WriteLine("No se puede venter");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"En Stock: {_stock}");
            return false;
        }
        else
        {
        _stock -= cantidad;
        
        Console.WriteLine("============= VENTA =============");
        Console.WriteLine("Venta exitosa");
        Console.WriteLine($"{Codigo}|{Nombre} Cantidad: {cantidad}");
        Console.WriteLine($"Stock actual: {_stock}");    
        return true;
        }
        
        
    }

    public void Reponer(int cantidad)
    {
        if (cantidad > 0)
        {
            Console.WriteLine("============= RESTOCK =============");
            Console.WriteLine("Restock exitoso");
            _stock += cantidad;    
        }
        
    }

    public bool NecesitaReposicion()
    {
        if (_stock <= StockMinimo)
        {
            Console.WriteLine("============= REPO =============");
            Console.WriteLine($"Necesita Restock:{Codigo} | {Nombre}" );
            Console.WriteLine($"Stock:{_stock} | Stock Mínimo: {StockMinimo}" );
            return true;

        }
        else
        {   
            Console.WriteLine("============= REPO =============");
            Console.WriteLine($"No necesita Restock:{Codigo} | {Nombre}" );
            return false;
        }


    }

    public void Mostrar()
    {
        Console.WriteLine("============= MOSTRAR =============");
        Console.WriteLine($"Codigo: {Codigo} | {Nombre} | {PrecioVenta.ToString("N0")} Gs. | {_stock}");
        

    }

    
}