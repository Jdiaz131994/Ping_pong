namespace Juego_ping_pong
{
    partial class Juego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Imgfondo2 = new System.Windows.Forms.PictureBox();
            this.pbPantallaPequeña = new System.Windows.Forms.PictureBox();
            this.tmrTiempoActualizar = new System.Windows.Forms.Timer(this.components);
            this.tmrTiempoDibujar = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgfondo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPantallaPequeña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(24, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(940, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Imgfondo2
            // 
            this.Imgfondo2.BackColor = System.Drawing.Color.Transparent;
            this.Imgfondo2.Image = ((System.Drawing.Image)(resources.GetObject("Imgfondo2.Image")));
            this.Imgfondo2.Location = new System.Drawing.Point(-1, 3);
            this.Imgfondo2.Name = "Imgfondo2";
            this.Imgfondo2.Size = new System.Drawing.Size(1024, 768);
            this.Imgfondo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imgfondo2.TabIndex = 0;
            this.Imgfondo2.TabStop = false;
            // 
            // pbPantallaPequeña
            // 
            this.pbPantallaPequeña.Location = new System.Drawing.Point(24, 12);
            this.pbPantallaPequeña.Name = "pbPantallaPequeña";
            this.pbPantallaPequeña.Size = new System.Drawing.Size(100, 50);
            this.pbPantallaPequeña.TabIndex = 4;
            this.pbPantallaPequeña.TabStop = false;
            // 
            // tmrTiempoActualizar
            // 
            this.tmrTiempoActualizar.Interval = 16;
            this.tmrTiempoActualizar.Tick += new System.EventHandler(this.tmrTiempoActualizar_Tick);
            // 
            // tmrTiempoDibujar
            // 
            this.tmrTiempoDibujar.Interval = 16;
            this.tmrTiempoDibujar.Tick += new System.EventHandler(this.tmrTiempoDibujar_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(411, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1012, 733);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbPantallaPequeña);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Imgfondo2);
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgfondo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPantallaPequeña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Imgfondo2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbPantallaPequeña;
        private System.Windows.Forms.Timer tmrTiempoActualizar;
        private System.Windows.Forms.Timer tmrTiempoDibujar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}