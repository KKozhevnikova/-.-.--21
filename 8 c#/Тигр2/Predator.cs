using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Тигр2
{
   public abstract class Predator : Animal
    {
       protected float startPosX;
        protected float startPosY;
        protected int count;
        public Color colorBody { protected set; get; }
       protected bool claws;
       protected string sex;
       protected double height;
        public abstract double Height { set; get; }
        public abstract void moveTiger(Graphics g);
        public abstract void faceSize(Graphics g);
        public virtual void SetPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }
        public void load(int count1)
        {
            if (count + count1 < MaxCount)
            {
                count += count1;
            }
        }
        public virtual int MaxCount { protected set; get; }
        public virtual int Max { protected set; get; }
        public int get()
        {
            int count2 = count;
            count = 0;
            return count2;
        }
        public virtual void setMainColor(Color color)
        {
            colorBody = color;
        }
        public abstract string getInfo();
    }
}
