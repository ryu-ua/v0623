using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0623
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        int Score = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           timer1.Enabled=false;
            MessageBox.Show("荒川 龍"); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label3.Left = fpos.X-label3.Width/2;
            label3.Top = fpos.Y-label3.Height/2;
            //label3.Text = $"{fpos.Y},{fpos.Y}";

            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx =Math.Abs(vx)*110/100;
            }

            if (label1.Top < 0)
            {
                vy =Math.Abs(vy) * 110 / 100;
            }


            if (label1.Right > ClientSize.Width)
            {
                vx =-Math.Abs(vx) * 110 / 100;
            }
            
            if (label1.Bottom > ClientSize.Height)
            {
                vy =-Math.Abs(vy) * 110 / 100;
            }

            Score--;
            label2.Text = $"SCORE{Score}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
