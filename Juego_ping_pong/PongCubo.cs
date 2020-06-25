using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_ping_pong
{
    class PongCubo
    {
        #region Propiedades
        public Point Posicion { get; set; }
        public PictureBox Texturas { get; set; }
        #endregion
        public int Altura { get; set; }
        public int Ancho { get; set; }
        public void Dibujar()
        {
            Texturas.Left = Posicion.X;
            Texturas.Top = Posicion.Y;
            Texturas.Height = Altura;
            Texturas.Width = Ancho;
        }
    }
}
