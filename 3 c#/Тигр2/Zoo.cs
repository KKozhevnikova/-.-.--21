using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Тигр;

namespace Тигр2
{
    class Zoo<T>
    {
        private T[] zoo;
        private T defaultValue;
        public static int operator +(Zoo<T> z, T tig)
        {
            {
                for (int i = 0; i < z.GetCountCletka; i++)
                {
                    if (z.CheckFreeCletka(i))
                    {
                        z.AddTiger(i,tig);
                        return i;
                    }
                }
            }
            return -1;
        }
        private int GetCountCletka { get { return zoo.Length; } }

        private bool CheckFreeCletka(int index)
        {
            if (index < 0 || index > zoo.Length)
            {
                return false;
            }
            if (zoo[index] == null)
            {
                return true;
            }

            return false;
        }

        private void AddTiger(int index, T tig)
        {
            zoo[index] = tig;
        }


        public static T operator -(Zoo<T> z, int index)
        {
            if (!z.CheckFreeCletka(index))
            {
                return z.GetTig(index);
            }
            return z.defaultValue;
        }

        private T GetTig(int index)
        {
            T tig = zoo[index];
            zoo[index] = defaultValue;
            return tig;
        }
        
        public Zoo(int kol, T delVal)
        {
            defaultValue = delVal;
            zoo = new T[kol];
            for (int i = 0; i < zoo.Length; i++)
            {
                zoo[i] = defaultValue;
            }  
        }
        
        public void Draw(Graphics gr, int CountTigInCletka, int widht, int height)
        {
            Pen pen = new Pen(Color.Black, 5);
            gr.DrawRectangle(pen, 0, 0, widht, height);
            int tigersCount = 0;
            for(int i = 0, chet = 0; i < widht; chet++)
            { 
                for(int j = 0; (j) * 190 < height; j++)
                {
                    if (tigersCount < zoo.Length)
                    {
                        if (zoo[tigersCount] != null)
                        {
                            if (zoo[tigersCount] is Animal)
                            {
                                (zoo[tigersCount] as Animal).SetPosition(45 + i, j * 150 + 30);
                                (zoo[tigersCount] as Animal).faceSize(gr);
                            }
                        }
                        tigersCount++;
                    }
                    gr.DrawLine(pen, i, j * 150 + 150, i + 190, j * 150 + 150);
                }
               
                    gr.DrawLine(pen, i + 190, 5, i + 190, height-5);
                   i += 190;
                
            }
        }
    }
}

