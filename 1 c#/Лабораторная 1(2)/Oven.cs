using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_1_2_
{
    class Oven
    {
       
        public bool ReadyToGo { set; get; }
        private Pan pan;
        public Pan Pan { set { pan = value; } get {return pan;} }
         
    }
}
