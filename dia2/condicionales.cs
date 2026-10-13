Console.WriteLine("=== Condicionales ===");
Console.WriteLine("Ingrese su edad");

int edad =  Convert.ToInt32(Console.ReadLine());

if (edad >= 18)
{
    
    Console.WriteLine("** Bienvenido **");
    if (edad>=20)
    {
        Console.WriteLine("Puede tomar alcohol");
    } else
    {
        Console.WriteLine("No puede tomar");
    }
    

}else
{
    
    Console.WriteLine("Es menor de 18, acceso denegado [!]");
    return;
}




