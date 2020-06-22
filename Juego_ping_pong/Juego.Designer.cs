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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.Imgfondo2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Imgfondo2)).BeginInit();
            this.SuspendLayout();
            // 
            // Imgfondo2
            // 
            this.Imgfondo2.BackColor = System.Drawing.Color.Transparent;
            this.Imgfondo2.Image = ((System.Drawing.Image)(resources.GetObject("Imgfondo2.Image")));
            this.Imgfondo2.Location = new System.Drawing.Point(-9, -61);
            this.Imgfondo2.Name = "Imgfondo2";
            this.Imgfondo2.Size = new System.Drawing.Size(811, 561);
            this.Imgfondo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imgfondo2.TabIndex = 0;
            this.Imgfondo2.TabStop = false;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Imgfondo2);
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            ((System.ComponentModel.ISupportInitialize)(this.Imgfondo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Imgfondo2;
    }
}