using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Dice_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int iRnd = new int();
            iRnd = r.Next(0, 5);
            // 1
            if (iRnd == 0)
                pictureBox8.Image = pictureBox1.Image;
            else if (iRnd == 1)
                pictureBox8.Image = pictureBox2.Image;
            else if (iRnd == 2)
                pictureBox8.Image = pictureBox3.Image;
            else if (iRnd == 3)
                pictureBox8.Image = pictureBox4.Image;
            else 
                pictureBox8.Image = pictureBox5.Image;

            // 2
            iRnd = r.Next(0, 5);
            if (iRnd == 0)
                pictureBox8.Image = pictureBox1.Image;
            else if (iRnd == 1)
                pictureBox7.Image = pictureBox2.Image;
            else if (iRnd == 2)
                pictureBox7.Image = pictureBox3.Image;
            else if (iRnd == 3)
                pictureBox7.Image = pictureBox4.Image;
            else
                pictureBox7.Image = pictureBox5.Image;

            // 2
            iRnd = r.Next(0, 5);
            if (iRnd == 0)
                pictureBox8.Image = pictureBox1.Image;
            else if (iRnd == 1)
                pictureBox6.Image = pictureBox2.Image;
            else if (iRnd == 2)
                pictureBox6.Image = pictureBox3.Image;
            else if (iRnd == 3)
                pictureBox6.Image = pictureBox4.Image;
            else
                pictureBox6.Image = pictureBox5.Image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
