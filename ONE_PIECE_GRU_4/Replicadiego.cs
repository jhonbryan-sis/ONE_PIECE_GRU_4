using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONE_PIECE_GRUP_4
{
    internal class EspadaReplica : ArticuloOnePiece, IEquipable, IVendible 
    {
        private double Precio;

        public EspadaReplica()
        {
            Nombre = "Wado Ichimonji";
            Precio = 5000;
        }

        public override double CalcularPrecioFinal()
        {
            return Precio;
        }

        public void Equipar()
        {
            Console.WriteLine("¡Has equipado la espada Wado Ichimonji!");
        }

        public void ProcesarVenta(int cantidad)
        {
            double total = Precio * cantidad;

            Console.WriteLine("Cantidad vendida: " + cantidad);
            Console.WriteLine("Total de la venta: " + total + " Berries");
        }
    }
}
