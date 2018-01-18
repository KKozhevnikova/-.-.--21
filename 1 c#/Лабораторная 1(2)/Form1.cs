using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_1_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Bowl bowl=new Bowl();
        private Mixercs mixercs = new Mixercs();
        private Spoon spoon = new Spoon();
        private Oven oven = new Oven();
        private Pan pan=new Pan();
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (numericUpDown2.Value == 200)
                {
                    bowl.Sugar = new Sugar[200];
                    for (int i = 0; i < 200; i++)
                    {
                        bowl.Sugar[i] = new Sugar();
                       
                    }
                   

                }
                else
                {
                    MessageBox.Show("Не то колоичества сахара");
                }
                //bowl.Butter = new Butter[150];
                //for (int i = 0; i < 150; i++)
                //    if (!bowl.Butter[i].Ready)
                //    {
                //        MessageBox.Show("Масло не растопленно");
                //        return;
                //    }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oven.ReadyToGo=true;
            button6.Enabled = true;
            if (!spoon.Mix2(bowl))
                MessageBox.Show("Не смешано");
            if (!mixercs.Mix(bowl))
                MessageBox.Show("Сахар и масло не взбиты");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            oven.Pan = pan;
            if (oven.Pan == null)
                MessageBox.Show("Шарики не готовы");
            if (pan.Pastry == null)
            {
                MessageBox.Show("На противне нет теста");
                return;
            }
            if (!oven.ReadyToGo)
            {
                MessageBox.Show("Духовка не разогрета");
                return;
            }
            if (!mixercs.Mix(bowl))
                MessageBox.Show("Сахар и масло не взбиты");
            if (!spoon.Mix2(bowl))
                MessageBox.Show("Не смешано");
             if (oven.Pan==null)
            {
                MessageBox.Show("Противня нет");
                return;
            }
             
             pan.Pastry.ReadyPastry = true;
             button8.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Овсяное печенье готово");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown5.Value ==150)
            {
                bowl.Butter = new Butter[150];
                for(int i=0;i<150;i++)
                {
                    bowl.Butter[i] = new Butter();
                    bowl.Butter[i].Ready = true;
                }
            }
            else
            {
                MessageBox.Show("Не то колоичества масло");
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numericUpDown4.Value ==90)
            {
                bowl.Oatmeal = new Oatmeal[90];
                for(int i=0;i<90;i++)
                {
                    bowl.Oatmeal[i] = new Oatmeal();
                }
            }
            else
            {
                MessageBox.Show("Не то колоичества  овсянки");
                return;
            }
            if (numericUpDown3.Value ==2)
            {
                bowl.Eggs = new Eggs[2];
                for(int i=0;i<2;i++)
                {
                    bowl.Eggs[i] = new Eggs();
                }
            }
            else
            {
                MessageBox.Show("Не то колоичества яйц");
                return;
            }
            if (numericUpDown6.Value ==250)
            {
                bowl.Flour = new Flour[250];
                for(int i=0;i<250;i++)
                {
                    bowl.Flour[i] = new Flour();
                }
            }
            else
            {
                MessageBox.Show("Не то колоичества муки");
                return;
            }
            if (numericUpDown1.Value ==10)
            {
                bowl.Baking = new Baking[10];
                for(int i=0;i<10;i++)
                {
                    bowl.Baking[i] = new Baking();
                }
            }
            else
            {
                MessageBox.Show("Не то колоичества разрыхлителя");
                return;
            }
            if (checkBox1.Checked)
            {
                bowl.Vanilla = new Vanillacs();
               
            }
            else
            {
                MessageBox.Show("Ваниль не добавлена");
                return;
            }
           
           if (!mixercs.Mix(bowl))
               MessageBox.Show("Сахар и масло не взбиты");
           
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
        pan.Pastry=bowl.GetPastry();  
            if(pan.Pastry==null)
                MessageBox.Show("Тесто не готово");
            if (!oven.ReadyToGo)
            {
                MessageBox.Show("Духовка не разогрета");
                return;
            }
            if (!mixercs.Mix(bowl))
                MessageBox.Show("Сахар и масло не взбиты");
            if (!spoon.Mix2(bowl))
                MessageBox.Show("Не смешано");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oven.Pan=pan;  
            if(oven.Pan==null)
                MessageBox.Show("Шарики не готовы");
            if (pan.Pastry == null)
            {
                MessageBox.Show("На противне нет теста");
                return;
            }
            if (!oven.ReadyToGo)
            {
                MessageBox.Show("Духовка не разогрета");
                return;
            }
            if (!mixercs.Mix(bowl))
                MessageBox.Show("Сахар и масло не взбиты");
            if (!spoon.Mix2(bowl))
                MessageBox.Show("Не смешано");
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        }
    
}
