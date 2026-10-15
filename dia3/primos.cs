double numero = 2; //100000000;
int cantidadPrimos = 0;
int limite = 15;
bool esPrimo ;

Console.WriteLine("### Buscando los primeros " + limite + " primos empezando desde : " + numero + " ###" );

while (cantidadPrimos < limite)
{
    esPrimo = true;
    
    for (int i = 2; i <= numero/2; i++)
    {
        if (numero %  i == 0)
        {
            esPrimo = false;
            break;
            
        }

    }
    if (esPrimo)
        {
            Console.WriteLine("Primo #"+(cantidadPrimos+1) + " : " + numero);
            
            cantidadPrimos ++;
            
        }
    numero += 1 ;   
    
}   