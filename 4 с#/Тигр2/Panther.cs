using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Тигр2
{
    public class Panther: Predator
    {
        protected int startX; 
        protected int startY;
        private int size;
        //private Color color;
     
        public Panther ( int size,bool claws, bool mustache, string sex, Color color)
        {
            this.claws = claws;
            this.sex = sex;
            this.colorBody = color;
            this.size = size;
            Random ran= new Random();
            startX = ran.Next(10, 200);
            startY = ran.Next(10, 200);
        }
        public override double Height
        {
            set
            {
                if (value > 1000 && value < 5000)
                    height = value;
            }
            get
            {
                return height;
            }
        }
        public override void moveTiger(Graphics g)
        {
            startX += 5;
            faceSize(g);
        }
        public override void faceSize(Graphics g)
        {
            tig(g);
        }
        public override void SetPosition(int x, int y)
        {
            startX = x;
            startY = y;
        }
        protected virtual void tig(Graphics g)
        {

            Pen pen = new Pen(Color.Orange, 5);
            Pen minipen = new Pen(Color.Orange, 2);

            g.DrawEllipse(pen, startX, startY, 90, 90);
            g.DrawEllipse(pen, startX + 25, startY + 25, 10, 10);
            g.DrawEllipse(pen, startX + 55, startY + 25, 10, 10);
            g.DrawEllipse(pen, startX + 44, startY + 40, 2, 3);
            g.DrawArc(minipen, startX + 30, startY + 40, 30, 10, 70, 170);
            g.DrawArc(minipen, startX + 30, startY + 40, 30, 10, -70, 170);
            g.DrawEllipse(pen, startX + 10, startY + 85, 20, 20);
            g.DrawEllipse(pen, startX + 60, startY + 85, 20, 20);
            g.DrawLine(pen, startX + 20, startY + 10, startX + 30, startY - 20);
            g.DrawLine(pen, startX + 40, startY, startX + 30, startY - 20);
            g.DrawLine(pen, startX + 50, startY, startX + 60, startY - 20);
            g.DrawLine(pen, startX + 70, startY + 10, startX + 60, startY - 20);
            //g.DrawArc(pen, startX+20,startY+45,50,20,20,140);
            g.DrawLine(minipen, startX + 50, startY + 45, startX + 120, startY + 35);
            g.DrawLine(minipen, startX + 50, startY + 45, startX + 120, startY + 50);
            g.DrawLine(minipen, startX + 50, startY + 45, startX + 120, startY + 65);
            g.DrawLine(minipen, startX + 38, startY + 45, startX - 40, startY + 35);
            g.DrawLine(minipen, startX + 38, startY + 45, startX - 40, startY + 50);
            g.DrawLine(minipen, startX + 38, startY + 45, startX - 40, startY + 65);

        }
    }
}
