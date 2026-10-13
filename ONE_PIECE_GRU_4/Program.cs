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

            // --- DOCENTE: Descomentar al aprobar los Pull Requests ---

          
            PrendaRopa sombrero = new PrendaRopa();
            sombrero.MostrarInfoBase();
            Console.WriteLine($"Precio Final: {sombrero.CalcularPrecioFinal()} Berries");
            sombrero.Equipar();

           

            Console.WriteLine("\nPresiona ENTER para salir...");
            Console.ReadLine();
        }
    }
}