using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Тигр2
{
    class Zoo<T>
    {
        private Dictionary<string, ZooStage<T>> zooStages;
        
        public Zoo(T defVal)
        {
            zooStages = new Dictionary<string, ZooStage<T>>();
            for (int i = 1; i < 6; i++)
            {
                zooStages.Add("L" + i, new ZooStage<T> (defVal,"L"+i) );
            }
        }

        public ZooStage<T> this[string index]
        {
            get
            {
                if (zooStages.ContainsKey(index))
                {
                    return zooStages[index];
                }
                else return null;
            }
        }

        public List<string> getLevels
        {
            get
            {
                return zooStages.Keys.ToList();
            }
        }
    }
}
