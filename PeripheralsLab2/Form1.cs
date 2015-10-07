using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeripheralsLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lineShape17.BorderColor = Color.Red;
            timer1.Stop();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (lineShape17.BorderColor == Color.Red)
            {
                panel4.BackColor = Color.Red;
                lineShape16.BorderColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lineShape16.BorderColor = Color.Black;
        }
    }
}
