using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Тигр
{
    interface Animal
    {
        double Height { set; get; }
        void moveTiger(Graphics g);
        void faceSize(Graphics g);
    }
}
