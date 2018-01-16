using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Тигр2
{
    public class ATiger : Panther,IComparable<ATiger>
    {
        private Color dopcolor;
        private bool streaks;
        public ATiger(Color dopcolor, bool streaks, int size, bool claws, bool mustache, string sex, Color color)
            : base(size, claws, mustache, sex, color)
        {
            this.dopcolor = dopcolor;
            this.streaks = streaks;
        }
        public int CompareTo(ATiger other)
        {
            int res = (this is Panther).CompareTo(other is Panther);
            if (res != 0)
            {
                return res;
            }
            if (this.streaks != other.streaks)
            {
                return this.streaks.CompareTo(other.streaks);
            }
            if (this.dopcolor != other.dopcolor)
            {
                this.dopcolor.Name.CompareTo(other.dopcolor.Name);
            }
            return 0;
        }
        public ATiger(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 5)
            {
                claws= Convert.ToBoolean(strs[0]);
                streaks = Convert.ToBoolean(strs[1]);
                dopcolor= Color.FromName(strs[2]);
                sex = strs[3];
                colorBody = Color.FromName(strs[4]);
            }
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
        public override string getInfo()
        {
            return claws + ";" + streaks + ";" + dopcolor.Name + ";" +
                sex + ";" + colorBody.Name;
        }
    }
}
