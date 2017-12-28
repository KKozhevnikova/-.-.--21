using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Тигр2
{
    public partial class Form1 : Form
    {
        Zoo<Animal> zoo;
        public Form1()
        {
            InitializeComponent();
            zoo = new Zoo<Animal>(10, null);

        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            zoo.Draw(gr, 5, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            
                var tig = new Panther(100, true, true, "women", Color.Black);

                int cletka = zoo + tig;
                Draw();
                MessageBox.Show("Кошка в клетке № " + cletka);
            


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
                var tig = new ATiger(Color.Black, true, 50, true, true, "men", Color.Black);

                int cletka = zoo + tig;
                Draw();
                MessageBox.Show("Кошка в клетке № " + cletka);

            
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                Animal tig = zoo - Convert.ToInt32(maskedTextBox1.Text);

                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                tig.SetPosition(50, 20);
                tig.faceSize(gr);
                pictureBox2.Image = bmp;
                Draw();

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
