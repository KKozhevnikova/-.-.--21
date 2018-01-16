using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_1_2_
{
    class Spoon
    {
        public bool Mix2(Bowl b)
        {
           if(! b.ReadyMixercs)
               return false;

           if (b.Oatmeal == null)
               return false;
           for (int i = 0; i < 90; i++)
           {
               if (b.Oatmeal[i] == null)
               {
                   return false;
               }
           }

           if (b.Eggs == null)
               return false;
           for (int i = 0; i < 2; i++)
           {
               if (b.Eggs[i] == null)
               {
                   return false;
               }
           }

           if (b.Flour == null)
               return false;
           for (int i = 0; i < 250; i++)
           {
               if (b.Flour[i] == null)
               {
                   return false;
               }
           }

           if (b.Baking == null)
               return false;
           for (int i = 0; i < 10; i++)
           {
               if (b.Baking[i] == null)
               {
                   return false;
               }
           }
            if(b.Vanilla==null)
            return false;

           b.ReadySpoon = true;
           return true;
            
        }

    }
}
