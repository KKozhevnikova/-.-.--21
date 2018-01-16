using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Тигр2
{
    class IndexOutOf: Exception
    {
        public IndexOutOf():
            base("В зоопарке нет животного по такому номеру клетки") { }
    }
}
