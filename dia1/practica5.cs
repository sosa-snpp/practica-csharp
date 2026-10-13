using System.Data;
using System.Net.Http.Headers;

Console.OutputEncoding = System.Text.Encoding.UTF8;
string negocio = "Kiosko el pibe";
Console.WriteLine("=== " + negocio + " ===");
Console.Write("Como se llama?");
string? cliente = Console.ReadLine();
DateTime ahora = DateTime.Now;
Console.WriteLine("Hola, " + cliente + ". son las " + ahora.ToString("HH:mm") );
Console.WriteLine("Gracias por visitarnos en " + negocio + ".");
