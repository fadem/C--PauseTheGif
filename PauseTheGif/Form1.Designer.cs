namespace PauseTheGif
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.pbCLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMove
            // 
            this.tmrMove.Interval = 1;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // pbCLogo
            // 
            this.pbCLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbCLogo.Image = global::PauseTheGif.Properties.Resources.CLogo2;
            this.pbCLogo.Location = new System.Drawing.Point(137, 58);
            this.pbCLogo.Name = "pbCLogo";
            this.pbCLogo.Size = new System.Drawing.Size(237, 406);
            this.pbCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCLogo.TabIndex = 0;
            this.pbCLogo.TabStop = false;
            this.pbCLogo.Visible = false;
            this.pbCLogo.Click += new System.EventHandler(this.pbCLogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::PauseTheGif.Properties.Resources.CLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(503, 503);
            this.Controls.Add(this.pbCLogo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Channel AYF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbCLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.PictureBox pbCLogo;
    }
}

