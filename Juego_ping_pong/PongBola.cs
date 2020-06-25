using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_ping_pong
{
    class PongBola: PongOrigen
    {
        public void Actualizar()
        {
            Posicion = new Point(Posicion.X + Velocidad.X, Posicion.Y + Velocidad.Y);
        }
    }
}
