using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;

namespace Juego_ping_pong
{
    public partial class Juego : Form
    {   //Parametros del formulario
        private const int AnchoPantalla = 1028;
        private const int AlturaPantalla = 768;
        //Velocidad base y Maxima
        private const int BaseVelPelota = 2;
        private int Nivel = 7;
        //Elementos para Jugar
        private PongOrigen Jugador1;
        private PongOrigen Jugador2;
        private PongBola Bola;
        //Pantalla del juego y variable aleatoria para movimiento de pelota
        private PongCubo PantallaPequeña;
        private Random random;
        //Puntaje de los jugadores
        private int PuntuacionJ1;
        private int PuntuacionJ2;
        public Juego()
        {
            InitializeComponent();
            ClientSize = new Size(AnchoPantalla, AlturaPantalla);
            //Initialize();
            Load += Juego_Load;
            pbJugador2.BackColor = Color.Transparent;
            pbJugador1.BackColor = Color.Transparent;
            pbBola.BackColor = Color.Transparent;
        }
        #region Metodos del juego

        private void ComenzarJuego()
        {
            _isGameRunning = true;
            ResetearBola();
            pbPantallaPequeña.Hide();

        }
        #endregion
        #region Eventos
        private void Juego_Load(object sender, EventArgs e)
        {
            CargarGraficos();
        }
        private void tmrTiempoActualizar_Tick(object sender, EventArgs e)
        {
            ActualizarEscena();
        }
        private void tmrTiempoDibujar_Tick(object sender, EventArgs e)
        {
            DibujarEscena();
        }
        #endregion
        #region EngineMethods
        private void Initialize()
        {
            random = new Random();
            Jugador1 = new PongOrigen();
            Jugador2 = new PongOrigen
            {
                Posicion = new Point(AnchoPantalla - 3, AlturaPantalla / 2)
            };
            Bola = new PongBola
            {
                Velocidad = new Point(2, 5)
            };
            PantallaPequeña = new PongCubo();
            PantallaPequeña.Posicion = new Point(0, 0);
            PantallaPequeña.Ancho = AnchoPantalla;
            PantallaPequeña.Altura = AlturaPantalla;
        }
        private void CargarGraficos()
        {
            pbJugador1.Load("RacketLeft.png");
            Jugador1.Texturas = pbJugador1;

            pbJugador2.Load("RacketRigth.png");
            Jugador2.Texturas = pbJugador2;

            pbBola.Load("Bola.png");
            Bola.Texturas = pbBola;

            pbPantallaPequeña.Load("Fondo.png");
            PantallaPequeña.Texturas = pbPantallaPequeña;
        }
        private void ActualizarEscena()
        {
            if (_isGameRunning)
            {
                ActualizarJugador();
                Bola.Actualizar();

                CheckColisionMuro();
                CheckMuroAfuera();
                CheckColisionRaqueta();
            }
            else if (MouseButtons == MouseButtons.Left)
            {
                ComenzarJuego();
            }
        }
        private bool _isGameRunning;
        private void DibujarEscena()
        {
            if (_isGameRunning)
            {
                Jugador1.Dibujar();
                Jugador2.Dibujar();
                Bola.Dibujar();
            }
            else
            {
                PantallaPequeña.Dibujar();
            }
        }
        #endregion
        #region Mechanics
        private int ActualY;
        private void ActualizarJugador()
        {
            int JugadorX = 0 + 30;
            int playerY = PointToClient(MousePosition).Y;
            Jugador1.Posicion = new Point(JugadorX, playerY);

            if (Jugador1.Texturas.Bottom >= AlturaPantalla)
            {
                Jugador1.Posicion = new Point(JugadorX, AlturaPantalla - Jugador1.Origen.Y - 1);
            }
            else if (Jugador1.Texturas.Top <= 0)
            {
                Jugador1.Posicion = new Point(JugadorX, Jugador1.Origen.Y + 1);
            }
            if (Keyboard.IsKeyDown(Key.S))
            {
                if (Jugador2.Texturas.Bottom >= AlturaPantalla)
                {
                    ActualY -= 0;
                }
                else
                {
                    ActualY += 30;
                }
                Jugador2.Posicion = new Point(AnchoPantalla - 30, ActualY);
            }
            else if (Keyboard.IsKeyDown(Key.W))
            {
                if (Jugador2.Texturas.Top <= 0)
                {
                    ActualY += 0;
                }
                else
                {
                    ActualY -= 30;
                }
                int Jugador2X = AnchoPantalla - 30;
                int Jugador2Y = ActualY;
                Jugador2.Posicion = new Point(Jugador2X, Jugador2Y);
            }
        }
        private void ResetearBola()
        {
            Nivel = 7;
            int VelocidadY = GenerateBallY();
            int VelocidadX = GenerarBolaX();
            Bola.Posicion = new Point(AnchoPantalla / 2, AlturaPantalla / 2);
            Bola.Velocidad = new Point(VelocidadX, VelocidadY);

            ActualBolaX = VelocidadX;
        }
        private int GenerarBolaX()
        {
            Nivel += 1;
            int velocityX = Nivel;
            if (random.Next(2) == 0)
            {
                velocityX *= -1;
            }
            return velocityX;
        }
        private int GenerateBallY()
        {
            Nivel += (int).5;
            int velocityY = random.Next(0, Nivel);
            if (random.Next(2) == 0)
            {
                velocityY *= -1;
            }
            return velocityY;
        }
        #endregion
        #region Collision
        private int ActualBolaX;
        private void CheckColisionMuro()
        {
            if (pbBola.Bottom >= AlturaPantalla)
            {
                Bola.Velocidad = new Point(ActualBolaX, -BaseVelPelota);
            }
            else if (pbBola.Top <= 0)
            {
                Bola.Velocidad = new Point(ActualBolaX, BaseVelPelota);
            }
        }
        private void CheckMuroAfuera()
        {
            if (pbBola.Left < 0)
            {
                ResetearBola();
                PuntuacionJ2 += 1;
                lblScore2.Text = PuntuacionJ2.ToString();
            }
            else if (pbBola.Right > AnchoPantalla)
            {
                ResetearBola();
                PuntuacionJ1 += 1;
                lblScore1.Text = PuntuacionJ1.ToString();
            }
        }
        private void CheckColisionRaqueta()
        {
            if (Bola.EsquIzquierda.X < Jugador1.EsqDerecha.X &&
                Bola.EsqInferiorIzquierda.Y > Jugador1.EsqInferiorDerecha.Y &&
                Bola.EsqDerecha.Y < Jugador1.EsqInferiorDerecha.Y)
            {
                ActualBolaX = GenerarBolaX();
                if (ActualBolaX < 0)
                {
                    ActualBolaX *= -1;
                }
                Bola.Velocidad = new Point(ActualBolaX, GenerateBallY());
            }
            if (Bola.EsqDerecha.X > Jugador2.EsquIzquierda.X &&
                Bola.EsqInferiorDerecha.Y > Jugador2.EsquIzquierda.Y &&
                Bola.EsqDerecha.Y < Jugador2.EsqInferiorIzquierda.Y)
            {
                ActualBolaX = GenerarBolaX();
                if (ActualBolaX > 0)
                {
                    ActualBolaX *= -1;
                }
                Bola.Velocidad = new Point(ActualBolaX, GenerateBallY());
            }
        }
        #endregion
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}



