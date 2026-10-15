using System.ComponentModel.DataAnnotations;
Jugador j1 = new Jugador("LIA",100);
Jugador j2 = new Jugador("TITO",80);

j1.RecibirAtaque(10);
j2.Curar(20);
j1.Mostrar();
j2.Mostrar();
Console.WriteLine("15 min de descanso");
j2.RecibirAtaque(10);
j1.Curar(20);
j1.Mostrar();
j2.Mostrar();

class Jugador
{
    public string Nombre;
    public int Vida;

    public Jugador(string nombre,int vida)
    {
        Nombre = nombre;
        Vida = vida;

    }

    public void RecibirAtaque(int puntos)
    {
        Vida = Vida - puntos;
    }
    public void Curar(int puntos)
    {
        Vida += puntos;
    }
    public void Mostrar()
    {
        Console.WriteLine(Nombre+" tiene "+Vida+" de vida");
    }
}


