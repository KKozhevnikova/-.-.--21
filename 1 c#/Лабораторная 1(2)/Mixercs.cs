using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_1_2_
{
    class Mixercs
    {
        public bool Mix(Bowl b)
        {
           
            if (b.Sugar == null)
                return false;
            for(int i=0;i<200;i++)
            {
                if (b.Sugar[i]==null)
                {
                    return false;
                }
            }
           
            if (b.Butter == null)
                return false;
            for (int i = 0; i < 150; i++)
            {
                if (b.Butter[i] == null)
                {
                    return false;
                }
            }
 b.ReadyMixercs = true;
            return true;
        }
    }
}
