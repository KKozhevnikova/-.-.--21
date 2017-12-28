using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Тигр
{
   public abstract class Predator : Animal
    {
       protected Color colorBody;
       protected bool claws;
       protected string sex;
       protected double height;
        public abstract double Height { set; get; }
        public abstract void moveTiger(Graphics g);
        public abstract void faceSize(Graphics g);
    }
}
