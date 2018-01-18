using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_1_2_
{
    class Bowl
    {
        public Oatmeal[] Oatmeal{set;get;}
        public Eggs[] Eggs {set;get;}
        public Flour[] Flour{set;get;}
        public Vanillacs Vanilla{set;get;}
        public Baking[] Baking {set;get;}
        public Butter[] Butter { set; get; }
        public Sugar[] Sugar { set; get; }
        public bool ReadySpoon { set; get; }

        public bool ReadyMixercs {set;get;}
        
        public Pastry GetPastry()
        {
            if(ReadySpoon && ReadyMixercs)
            {
                return new Pastry();
            }
            return null;
        }

    }
}
