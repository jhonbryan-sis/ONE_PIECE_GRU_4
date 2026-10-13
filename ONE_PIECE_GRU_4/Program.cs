using ONE_PIECE_GRU_4;
using System;

namespace ONE_PIECE_GRUP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("=== BIENVENIDOS A LA TIENDA DE GRAND LINE ===");
            Console.WriteLine("=================================================\n");
            Console.WriteLine("Esperando la llegada de la mercancía (Pull Requests)...\n");

           
            Figura_Accion luffy = new Figura_Accion();
            luffy.Nombre = "figura de accion";
            luffy.Personaje = "Monkey D. Luffy";
            luffy.MostrarInfoBase();
            Console.WriteLine($"Precio Final (con envío): {luffy.CalcularPrecioFinal()} Berries");


            Console.WriteLine("\nPresiona ENTER para salir...");
            Console.ReadLine();
        }
    }
}