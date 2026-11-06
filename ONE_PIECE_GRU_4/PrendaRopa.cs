using ONE_PIECE_GRUP_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONE_PIECE_GRUP_4
{
    public class PrendaRopa : ArticuloOnePiece, IEquipable, IVendible
    {
     public PrendaRopa()
        {
        }
        public override double CalcularPrecioFinal()
        {
            return PrecioBase;
        }
        public void Equipar()
        {
            Console.WriteLine("La prenda de ropa fue equipada");
        }
        public void ProcesarVenta(int cantidad)
        {
            Console.WriteLine($"Se proceso la venta de {cantidad} prenda(s) de ropa");
        }
    }
}
