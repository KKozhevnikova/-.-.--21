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
    public partial class Form2 : Form
    {
        Animal animal = null;
        public Animal getTig { get { return animal; } }
        /// <summary>
        /// </summary>
        private void Draw()
        {
            if (animal != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                animal.SetPosition(20, 20);
                animal.faceSize(gr);
                pictureBox1.Image = bmp;
            }
        }

        public Form2()
        {
            InitializeComponent();
          
            panel1.MouseDown += panelColor_MouseDown;
            panel2.MouseDown += panelColor_MouseDown;
            panel3.MouseDown += panelColor_MouseDown;
            panel4.MouseDown += panelColor_MouseDown;
            panel5.MouseDown += panelColor_MouseDown;
            panel6.MouseDown += panelColor_MouseDown;

            button2.Click += (object sender, EventArgs e) => { Close(); };
        
        }

        private void label(object sender, MouseEventArgs e)
        {
            label1.DoDragDrop(label1.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelto(object sender, MouseEventArgs e)
        {
            label2.DoDragDrop(label2.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelTiger1(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Тигр":
                    animal = new Panther(100, true,true, "Women",Color.Black);
                    break;
                case "Амурский тигр":
                    animal = new ATiger(Color.Black, true, 4, true, true, "men", Color.Orange);
                    break;
            }
            Draw();
        }

        private void panelTiger2(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (animal!= null)
            {
                animal.setMainColor((Color)e.Data.GetData(typeof(Color)));
                Draw();
            }
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (animal != null)
            {
                if (animal is ATiger)
                {
                    (animal as ATiger).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    Draw();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            animal = null;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
