using NLog;
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
        Zoo zoo;
        Form2 form2;
        //private Logger log;
        public Form1()
        {
            InitializeComponent();
           // log = LogManager.GetCurrentClassLogger();
            zoo = new Zoo(null);
           // var levels = zoo.;
            //zoo.Draw(gr,5,pictureBox1.Width,pictureBox1.Width);
            //foreach (var level in levels)
            //{
                listBox1.Items.Add("Level1");
                listBox1.Items.Add("Level2");
                listBox1.Items.Add("Level3");
                listBox1.Items.Add("Level4");
                listBox1.Items.Add("Level5");


        }


        private void Draw()
        {
            if (listBox1.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                zoo[listBox1.SelectedIndex].Draw(gr);
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

        //private void button1_Click_1(object sender, EventArgs e)
        //{


        //        var tig = new Panther(100, true, true, "women", Color.Black);

        //        int cletka = zoo + tig;
        //        Draw();
        //        MessageBox.Show("Клетка: " + cletka);



        //}

        //private void button2_Click_1(object sender, EventArgs e)
        //{

        //        var tig = new ATiger(Color.DarkOrange, true, 50, true, true, "men", Color.Black);

        //        int cletka = zoo + tig;
        //        Draw();
        //        MessageBox.Show("Ваше место: " + cletka);


        //}
        //private void button3_Click_1(object sender, EventArgs e)
        //{
        //    if (maskedTextBox1.Text != "")
        //    {
        //        Animal tig = zoo - Convert.ToInt32(maskedTextBox1.Text);

        //        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
        //        Graphics gr = Graphics.FromImage(bmp);
        //        tig.SetPosition(50, 20);
        //        tig.faceSize(gr);
        //        pictureBox2.Image = bmp;
        //        Draw();

        //    }
        //}

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (listBox1.SelectedIndex > -1)
            //{
            //    string level = listBox1.Items[listBox1.SelectedIndex].ToString();
            //    Random rnd = new Random();
            //    Animal tig = null;
            //    switch (rnd.Next(0, 4))
            //    {
            //        case 0:
            //            tig = new Panther(100, true, true, "Women", getRandomColor());
            //            break;
            //        case 1:
            //            tig = new Panther(100, true, true, "Women", getRandomColor());
            //            break;
            //        case 2:
            //            tig = new ATiger(Color.Black, true, 4, true, true, "men", getRandomColor());
            //            break;
            //        case 3:
            //            tig = new ATiger(Color.Black, true, 4, true, true, "men", getRandomColor());
            //            break;
            //    }
            //    if (tig != null)
            //    {
            //        int zoos = zoo[level] + tig;
            //        try
            //        {
            //            Draw();
            //            MessageBox.Show("Клетка: " + zoos);
            //        }
            //        catch (Overflow ex)
            //        {
            //            MessageBox.Show(ex.Message, "Ошибка переполнения",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message, "Общая ошибка",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}

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
                    try
                    {
                        int place = zoo[listBox1.SelectedIndex] + tig;
                        if (place > -1)
                        {
                            Draw();
                            MessageBox.Show("Ваше место: " + place);

                        }
                       // log.Info("Добавили животного: " + listBox1.Items[listBox1.SelectedIndex].ToString());
                    }

                    catch (Overflow ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка переполнения",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Общая ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    try
                    {
                        Animal tig = zoo[listBox1.SelectedIndex] - Convert.ToInt32(maskedTextBox1.Text);
                        if (tig != null)
                        {
                            Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                            Graphics gr = Graphics.FromImage(bmp);
                            tig.SetPosition(30, 30);
                            tig.faceSize(gr);
                            pictureBox2.Image = bmp;
                            Draw();
                        }
                    }
                    catch (IndexOutOf ex)
                    {
                        MessageBox.Show(ex.Message, "Неверный номер",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Общая ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        if (zoo.LoadData(openFileDialog1.FileName))
        //        {
        //            MessageBox.Show("Загрузили", "",
        //                MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Не загрузили", "",
        //                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        Draw();
        //    }
        //}

        //private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        if (zoo.SaveData(saveFileDialog1.FileName))
        //        {
        //            MessageBox.Show("Сохранение прошло успешно", "",
        //                MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Не сохранилось", "",
        //                MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        private void button3_Click_1(object sender, EventArgs e)
        {
            zoo.Sort();
        }
    }



}
