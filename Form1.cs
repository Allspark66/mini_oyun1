using System;
using System.Drawing;
using System.Windows.Forms;

namespace minioyun
{
    public partial class Form1 : Form
    {
        int carSpeed = 0;
        PictureBox car;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;

            car = pictureBox1;
            car.BackColor = Color.Transparent;
            
            car.BringToFront();

            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            timer1.Start();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control x in panel1.Controls)
            {
                if (x.Tag != null && x.Tag.ToString() == "road")
                {
                    x.Top += carSpeed;
                    if (x.Top >= panel1.Height)
                        x.Top = -x.Height;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carSpeed = 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carSpeed = 0;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (car.Left > 0)
                car.Left -= 10;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (car.Right < this.ClientSize.Width)
                car.Left += 10;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (car.Top < this.ClientSize.Height - car.Height)
                car.Top += 10;
        }
      


    }
}
