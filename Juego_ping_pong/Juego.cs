using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
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
        private int _Nivel = 7;
        //Elementos para Jugar
        private PongOrigen Jugador1;
        private PongOrigen Jugador2;
        private PongBola Pelota;
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
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
        }
        #region Metodos del juego

        private void ComenzarJuego()
        {
            _isGameRunning = true;
            ResetBall();
            pbPantallaPequeña.Hide();

        }
        #endregion
        #region Eventos
        private void Juego_Load(object sender, EventArgs e)
        {
            LoadGraphicsContent();
        }
        private void tmrTiempoActualizar_Tick(object sender, EventArgs e)
        {
            UpdateScene();
        }
        private void tmrTiempoDibujar_Tick(object sender, EventArgs e)
        {
            DrawScene();
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
            Pelota = new PongBola
            {
                  Velocidad = new Point(2, 5)
            };
            PantallaPequeña = new PongCubo();
            PantallaPequeña.Posicion = new Point(0, 0);
            PantallaPequeña.Ancho = AnchoPantalla;
            PantallaPequeña.Altura = AlturaPantalla;
        }

        private void LoadGraphicsContent()
        {
            pbPlayer1.Load("Paddle1.png");
            _player1.Texture = pbPlayer1;


            pictureBox1.Load("Paddle2.png");
            _player2.Texture = pictureBox1;

            pbBall.Load("Ball.png");
            _ball.Texture = pbBall;

            pbTitleScreen.Load("Fondo.png");
            PantallaPequeña.Texture = pbTitleScreen;
        }

        private void UpdateScene()
        {
            if (_isGameRunning)
            {
                UpdatePlayer();
                _ball.Update();

                CheckWallCollision();
                CheckWallOut();
                CheckPaddleCollision();
            }
            else if (MouseButtons == MouseButtons.Left)
            {
                BeginGame();
            }
        }

        private bool _isGameRunning;
        private void DrawScene()
        {
            if (_isGameRunning)
            {
                _player1.Draw();
                _player2.Draw();
                _ball.Draw();
            }
            else
            {
                PantallaPequeña.Draw();
            }
        }

        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
