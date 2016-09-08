using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B2D1_week1_1_Robot.model;

namespace B2D1_week1_1_Robot
{
    public partial class Form1 : Form
    {
        private Robot mijnRobot;
        public Form1()
        {
            InitializeComponent();
        }

        private void bInitialiseer_Click(object sender, EventArgs e)
        {
            int p; //plaats
            int r; //richting
            p = Convert.ToInt32(nudPlaats.Value);
            r = Convert.ToInt32(nudRichting.Value);
            mijnRobot = new Robot(r,p);
        }

        private void bzetStap_Click(object sender, EventArgs e)
        {
            if (mijnRobot != null)
            {
                mijnRobot.zetEenStap();
            }
        }

        private void bgaNaar_Click(object sender, EventArgs e)
        {
            if (mijnRobot != null)
            {
                mijnRobot.gaNaar(Convert.ToInt32(textBox1.Text));
            }
        }
    }
}
