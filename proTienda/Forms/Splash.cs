using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proTienda
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 7000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
            progressBar1.Value = 100;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            
            tmr.Stop();
           
            Login Login = new Login();
            Login.Show();
           
            this.Hide();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
