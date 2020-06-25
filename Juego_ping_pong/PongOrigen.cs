using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_ping_pong
{
    class PongOrigen
    {
        public Point Origen
        {
            get
            {
                return new Point(Texturas.Width / 2 , Texturas.Height / 2);
            }
        }
        public PictureBox Texturas { get; set; }
        public Point Posicion { get; set; }
        public Point Velocidad { get; set; }
        public Point EsquIzquierda
        {
            get { return new Point(Posicion.X - Origen.X, Posicion.Y - Origen.Y); }
        }
        public Point EsqDerecha
        {
            get { return new Point(Posicion.X + Origen.X, Posicion.Y - Origen.Y); }
        }
        public Point EsqInferiorIzquierda
        {
            get { return new Point(Posicion.X - Origen.X, Posicion.Y + Origen.Y); }
        }
        public Point EsqInferiorDerecha
        {
            get { return new Point(Posicion.X + Origen.X, Posicion.Y + Origen.Y); }
        }
        public void Dibujar()
        {
            Texturas.Location = new Point(Posicion.X - Origen.X,Posicion.Y - Origen.Y);
        }
    }
}
