namespace Juego_ping_pong
{
    partial class Ping_Pong
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ping_Pong));
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picbox2 = new System.Windows.Forms.PictureBox();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.Imgstart = new System.Windows.Forms.PictureBox();
            this.Imgfondo1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgstart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgfondo1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtP1
            // 
            this.txtP1.AcceptsReturn = true;
            this.txtP1.AccessibleDescription = "";
            this.txtP1.AccessibleName = "";
            this.txtP1.BackColor = System.Drawing.SystemColors.Window;
            this.txtP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtP1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtP1.Location = new System.Drawing.Point(269, 162);
            this.txtP1.MaxLength = 30;
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(220, 24);
            this.txtP1.TabIndex = 2;
            this.txtP1.Text = "Nombre de Player 1";
            this.txtP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //this.txtP1.TextChanged += new System.EventHandler(this.txtP1_TextChanged);
            this.txtP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            //this.txtP1.Leave += new System.EventHandler(this.txtP1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 5;
            // 
            // txtP2
            // 
            this.txtP2.AcceptsReturn = true;
            this.txtP2.AccessibleDescription = "";
            this.txtP2.AccessibleName = "";
            this.txtP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtP2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtP2.Location = new System.Drawing.Point(269, 213);
            this.txtP2.MaxLength = 30;
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(220, 24);
            this.txtP2.TabIndex = 6;
            this.txtP2.Text = "Nombre de Player 2";
            this.txtP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtP2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(147, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 7;
            // 
            // picbox2
            // 
            this.picbox2.Location = new System.Drawing.Point(81, 55);
            this.picbox2.Name = "picbox2";
            this.picbox2.Size = new System.Drawing.Size(60, 24);
            this.picbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox2.TabIndex = 4;
            this.picbox2.TabStop = false;
            // 
            // picbox1
            // 
            this.picbox1.Location = new System.Drawing.Point(81, 25);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(60, 24);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox1.TabIndex = 3;
            this.picbox1.TabStop = false;
            // 
            // Imgstart
            // 
            this.Imgstart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Imgstart.Image = global::Juego_ping_pong.Properties.Resources.Comienzo;
            this.Imgstart.Location = new System.Drawing.Point(256, 312);
            this.Imgstart.Name = "Imgstart";
            this.Imgstart.Size = new System.Drawing.Size(246, 93);
            this.Imgstart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imgstart.TabIndex = 1;
            this.Imgstart.TabStop = false;
            this.Imgstart.Click += new System.EventHandler(this.comienzo_click);
            // 
            // Imgfondo1
            // 
            this.Imgfondo1.Image = ((System.Drawing.Image)(resources.GetObject("Imgfondo1.Image")));
            this.Imgfondo1.Location = new System.Drawing.Point(-2, 0);
            this.Imgfondo1.Name = "Imgfondo1";
            this.Imgfondo1.Size = new System.Drawing.Size(804, 489);
            this.Imgfondo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imgfondo1.TabIndex = 0;
            this.Imgfondo1.TabStop = false;
            // 
            // Ping_Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbox2);
            this.Controls.Add(this.picbox1);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.Imgstart);
            this.Controls.Add(this.Imgfondo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Ping_Pong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping_Pong";
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgstart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgfondo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Imgfondo1;
        private System.Windows.Forms.PictureBox Imgstart;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.PictureBox picbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.Label label2;
    }
}

