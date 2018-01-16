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
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            zoo = new Zoo<Animal>(null);
            var levels = zoo.getLevels;
            foreach (var level in levels)
            {
                listBox1.Items.Add(level);
            }
        }
        private void Draw()
        {
            if (listBox1.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                zoo[listBox1.Items[listBox1.SelectedIndex].ToString()].Draw(gr);
                pictureBox1.Image = bmp;
            }
        }
        private Color getRandomColor()
        {
            Random rnd = new Random();
            return Color.FromArgb(rnd.Next(0, 254), rnd.Next(0, 254), rnd.Next(0, 254));
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string level = listBox1.Items[listBox1.SelectedIndex].ToString();
                Random rnd = new Random();
                Animal tig = null;
                switch (rnd.Next(0, 4))
                {
                    case 0:
                        tig = new Panther(100, true, true, "Women", getRandomColor());
                        break;
                    case 1:
                        tig = new Panther(100, true, true, "Women", getRandomColor());
                        break;
                    case 2:
                        tig = new ATiger(Color.Black, true, 4, true, true, "men", getRandomColor());
                        break;
                    case 3:
                        tig = new ATiger(Color.Black, true, 4, true, true, "men", getRandomColor());
                        break;
                }
                if (tig != null)
                {
                    int zoos = zoo[level] + tig;
                    if (zoos > -1)
                    {
                        Draw();
                        MessageBox.Show("Клетка: " + zoos);
                    }
                    else
                    {
                        MessageBox.Show("Извинте, на этом уровне нет мест");
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                form2 = new Form2();
                form2.ShowDialog();
                string level = listBox1.Items[listBox1.SelectedIndex].ToString();
                var tig = form2.getTig;
                if (tig != null)
                {
                    int place = zoo[level] + tig;
                    if (place > -1)
                    {
                        Draw();
                        MessageBox.Show("Ваше место: " + place);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string level = listBox1.Items[listBox1.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    Animal tig = zoo[level] - Convert.ToInt32(maskedTextBox1.Text);
                    if (tig != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        tig.SetPosition(30, 30);
                        tig.faceSize(gr);
                        pictureBox2.Image = bmp;
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("В этой клетке нет животного");
                    }
                }
            }
        }

    }
}
