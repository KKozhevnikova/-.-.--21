using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Тигр2
{
    class Overflow: Exception
    {
        public Overflow():
            base("В зоопарке нет свободных клеток") { }
    }
}
