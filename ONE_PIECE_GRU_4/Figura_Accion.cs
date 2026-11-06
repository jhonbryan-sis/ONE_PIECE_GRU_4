using ONE_PIECE_GRUP_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONE_PIECE_GRU_4
{
    public class Figura_Accion : ArticuloOnePiece
    {public override double CalcularPrecioFinal() 
        {
            return PrecioBase + 50;
        }
    }
}
