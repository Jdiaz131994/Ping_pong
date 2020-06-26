using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_ping_pong
{
    public partial class Ping_Pong : Form
    {
        int p1 = 0, p2=0;
        public Ping_Pong()
        {
            InitializeComponent();
        }


        private void comienzo_click(object sender, EventArgs e)
        {
            if(p1 == 1 || p2 == 1)
            {
                Juego frm = new Juego();
                frm.Show();
            }

        }  
        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (this.txtP1.Text != "Nombre de Player 1")
                {
                    if (this.txtP1.Text == null || this.txtP1.Text == "")
                    {
                        MessageBox.Show("Por favor ingrese un usuario.");
                    }
                    else
                    { 
                        string t = (string.Format(txtP1.Text));

                        label1.Text = t.ToString();

                        txtP1.Text = "";

                        picbox1.Image = Properties.Resources.conectado;

                        p1 = 1;

                        this.txtP1.Enabled = false;
                    }
                }
            }
        }

  
        private void txtP2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (this.txtP2.Text != "Nombre de Player 2")
                {
                    if (this.txtP2.Text == null || this.txtP2.Text == "")
                    {
                        MessageBox.Show("Por favor ingrese un usuario.");
                        this.txtP1.Text = "Nombre de Player 2";
                    }
                    else
                    {
                        string t = (string.Format(txtP2.Text));

                        label2.Text = t.ToString();

                        txtP2.Text = "";

                        picbox2.Image = Properties.Resources.conectado;

                        p2 = 1;

                        this.txtP2.Enabled = false;
                    }
                }
            }
        }
    }
}
