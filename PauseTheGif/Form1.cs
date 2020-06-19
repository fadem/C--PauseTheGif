using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PauseTheGif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbCLogo.Location = new Point(-240, 40);
            pbCLogo.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrMove.Start();
        }

     

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            pbCLogo.Left += 40;
            if(pbCLogo.Left > this.Left)
            {
                pbCLogo.Location = new Point(-240, 40);

            }
        }

        private void pbCLogo_Click(object sender, EventArgs e)
        {
        }

        bool click = false;
        private void Form1_Click(object sender, EventArgs e)
        {
           if(!click)
            {
                tmrMove.Stop();
                click = true;
            }
           else
            {
                tmrMove.Start();
                click = false;

            }
        }
    }
}
