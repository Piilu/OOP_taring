using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piil_rainer_täring
{
    public partial class Form1 : Form
    {
        public int juku;
        public int peeter;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnStartNew_Click(object sender, EventArgs e)
        {
            jukuScore.Text = "";
            lblJukuRand1.Text = "";
            lblJukuRand2.Text = "";
            peeterScore.Text = "";
            lblPeeterRand1.Text = "";
            lblPeeterRand2.Text = "";
            lblTulemus.Text = "";
            btnStartNew.Enabled = false;
            playJuku.Enabled = true;
        }
        private void playJuku_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random1 = rnd.Next(1, 7);
            int random2 = rnd.Next(1, 7);
            lblJukuRand1.Text = random1.ToString();
            lblJukuRand2.Text = random2.ToString();
            jukuScore.Text = (random1 + random2).ToString();
            playJuku.Enabled = false;
            playPeeter.Enabled = true;
        }

        private void playPeeter_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random1 = rnd.Next(1, 7);
            int random2 = rnd.Next(1, 7);
            lblPeeterRand1.Text = random1.ToString();
            lblPeeterRand2.Text = random2.ToString();
            peeterScore.Text = (random1 + random2).ToString();
            btnStartNew.Enabled = true;
            playPeeter.Enabled = false;
            juku = Convert.ToInt32(jukuScore.Text);
            peeter = Convert.ToInt32(peeterScore.Text);
            if (juku > peeter)
            {
                lblTulemus.Text = "Võitis Juku";
            }
            else if (peeter > juku)
            {
                lblTulemus.Text = "Võitis Peeter";

            }
            else
            {
                lblTulemus.Text = "Viik";

            }


        }


    }
}
