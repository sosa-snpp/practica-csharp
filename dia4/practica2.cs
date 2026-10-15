string FormatoGs(double monto)
{
    return monto.ToString("N0")+" Gs.";
}

double CalcularSubTotal(double precio, int cantidad)
{
    return (precio*cantidad);
}
double AplicarDescuento(double subtotal,double porcentaje)
{    
    return ((subtotal -( subtotal*(porcentaje/100))));
}
double CalcularIva(double monto,int tasa)
{
    return Math.Round(monto*tasa/(100+tasa)) ;
}



Dictionary<string,double> precios = new Dictionary<string, double>
{
    {"Medialuna",2500},
    {"Chipa",3000},
    {"Pan",12000},    
    {"Gaseosa",8000},
    {"Leche",95000}    
};

Dictionary<string,int> tasaIva = new Dictionary<string, int>
{
    {"Medialuna",10},
    {"Chipa",10},
    {"Pan",5},    
    {"Gaseosa",10},
    {"Leche",5}    
    
};

Console.WriteLine("=== Catalogo ===");
foreach (string producto in precios.Keys)
{
    Console.WriteLine(producto + " : " + FormatoGs(precios[producto]) + " IVA incluido " + tasaIva[producto] + "%" );
    
}
Console.WriteLine("=== ======== ===");


List<string> carrito = new List<string>();
List<int> unidades = new List<int> ();

string respuesta = "s";

while (respuesta == "s")
{
    Console.WriteLine("Producto");
    string? nombre = Console.ReadLine();
    if (!precios.ContainsKey(nombre!))
    {
        Console.WriteLine("Ese producto no esta en el catalogo");
    }
    else
    {
        Console.Write("Cantidad: ");        
        int cantidadPedida = int.Parse(Console.ReadLine()!);
        carrito.Add(nombre!);
        unidades.Add(cantidadPedida);

    }
    Console.WriteLine("Agregar otro producto? S/N");

    respuesta = Console.ReadLine()!;

}


Console.WriteLine("Descuento en porcentaje (0 si no hay)");
double descuento = double.Parse(Console.ReadLine()!);

double totalBruto = 0;
double totalNeto = 0;
double iva10 = 0;
double iva5 = 0 ; 

Console.WriteLine("====FACTURA====");

for (int i = 0; i < carrito.Count; i++)
{
    string nombreItem = carrito[i];
    double bruto = CalcularSubTotal(precios[nombreItem],unidades[i]);
    double neto = AplicarDescuento(bruto,descuento);

    totalBruto += bruto;
    totalNeto += neto;

    if (tasaIva[nombreItem] == 10)
    {
        iva10 += CalcularIva(neto,10);
    }
    else
    {
        iva5 += CalcularIva(neto,5);
    }   

    Console.WriteLine(unidades[i]+" x "+nombreItem+" : "+FormatoGs(bruto));
    
}
Console.WriteLine("=============================");
Console.WriteLine("Subtotal: "+FormatoGs(totalBruto));
Console.WriteLine("Descuento: "+ descuento + " % -" + FormatoGs(totalBruto-totalNeto) );
Console.WriteLine("TOTAL A PAGAR: "+ FormatoGs(totalNeto));
Console.WriteLine("IVA 10% incluido: "+ FormatoGs(iva10));
Console.WriteLine("IVA 5% incluido: "+ FormatoGs(iva5));
Console.WriteLine("=============================");