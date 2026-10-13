Console.WriteLine("=== Conversión de Guaraníes a Dólares ===");
Console.WriteLine("Escriba la cotización del día");
double cotizatcion = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escriba el monto a convertir");
double monto = Convert.ToDouble(Console.ReadLine());
double dolares = monto / cotizatcion ;
Console.WriteLine("=========================================");
Console.WriteLine("Son dolares $ " + $"{dolares:N2}");
Console.WriteLine("=========================================");



