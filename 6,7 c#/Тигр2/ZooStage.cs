using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Тигр;

namespace Тигр2
{
    class ZooStage<T>
    {
       // private T[] zoo;
        private Dictionary<int, T> zoo;
        public int maxTig = 16;
        string level = "";
        private T defaultValue;

        public ZooStage(T delVal, string lev)
        {
            defaultValue = delVal;
            zoo = new Dictionary<int, T>();
            level = lev;
        }
        public static int operator +(ZooStage<T> z, T tig)
        {
            
                if (z.zoo.Count == z.maxTig)
                {
                    throw new Overflow();
                }
                for (int i = 0; i < z.GetCountCletka; i++)
                {
                    if (z.CheckFreeCletka(i))
                    {
                        z.AddTiger(i,tig);
                        return i;
                    }
                }
            z.zoo.Add(z.zoo.Count, tig);
            return z.zoo.Count - 1;
        }

        private int GetCountCletka { get { return maxTig; } }

        private bool CheckFreeCletka(int index)
        {
            
            return !zoo.ContainsKey(index);
        }
        private void AddTiger(int index, T tig)
        {
            zoo.Add(index,tig);
        }
        

        public static T operator -(ZooStage<T> z, int index)
        {
            if (!z.CheckFreeCletka(index))
            {
                return z.GetTig(index);
            }
            throw new IndexOutOf();
        }
        public T GetTig(int index)
        {
            T tig=default(T);
            if (zoo.ContainsKey(index)) { 
                tig = zoo[index];
            zoo.Remove(index);
        }
            return tig;
        }
        public ZooStage(int kol, T delVal)
        {
            defaultValue = delVal;
            zoo = new Dictionary<int,T>();
            for (int i = 0; i < 16; i++)
            {
                zoo[i] = defaultValue;
            }
        }

        public void Draw(Graphics gr)
        {
            const int widht = 850;
            const int height = 600;
            //const int spaceForTig = 80;
            Pen pen = new Pen(Color.Gray, 5);
            gr.DrawRectangle(pen,0,0,widht,height);
            int tigersCount=0;
            gr.DrawString(level, new Font("Arial", 30), new SolidBrush(Color.Blue), widht -150, height-50 );
            for(int i=0,chet=0;i<widht;chet++)
            { 
                for(int j=0; (j)*190<height;j++,tigersCount++)
                {
                    if (zoo.ContainsKey(tigersCount))
                    {
                       
                            if (zoo[tigersCount] is Animal)
                            {
                                (zoo[tigersCount] as Animal).SetPosition(45 + i, j * 150 + 30);
                                (zoo[tigersCount] as Animal).faceSize(gr);
                            }
                        }
                    else 
                    {
                        gr.DrawString(tigersCount.ToString(), new Font("Arial", 20), new SolidBrush(Color.Black), i + 40, j*150 + 30);
                    }
                    
                    gr.DrawLine(pen, i, j * 150 + 150, i + 190, j * 150 + 150);
                }
               
                    gr.DrawLine(pen, i+190, 5, i + 190, height-5);
                   i += 190;
                
            }
        }
    }
}

