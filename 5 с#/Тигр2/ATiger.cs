using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Тигр2
{
    public class ATiger : Panther
    {
        private Color dopcolor;
        private bool streaks;
        public ATiger(Color dopcolor, bool streaks, int size, bool claws, bool mustache, string sex, Color color)
            : base(size, claws, mustache, sex, color)
        {
            this.dopcolor = dopcolor;
            this.streaks = streaks;
        }
        protected override void tig(Graphics g)
        {
            base.tig(g);
            Pen pen = new Pen(dopcolor, 2);
            Pen woofpen = new Pen(dopcolor, 4);
            g.DrawArc(pen, startX + 38, startY + 38, 15, 20, 20, 140);
            g.DrawArc(woofpen, startX + 20, startY - 5, 50, 10, 20, 140);
            g.DrawArc(woofpen, startX - 40, startY + 40, 170, 30, 20, 140);
            g.DrawArc(woofpen, startX - 18, startY + 50, 125, 30, 20, 140);
        }

        public void setDopColor(Color color)
        {
            dopcolor = color;
        }
    }
}
