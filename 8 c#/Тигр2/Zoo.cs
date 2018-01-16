using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Тигр2
{
    class Zoo
    {
        private List< ZooStage<Animal> > zooStages;
        public Zoo(Animal defVal)
        {
            zooStages = new List<ZooStage<Animal>>();
            for (int i = 1; i < 6; i++)
            {
                zooStages.Add(new ZooStage<Animal>(defVal,"L"+i));
            }
        }
        public void Sort()
        {
            zooStages.Sort();
        }
        public ZooStage<Animal> this[int index]
        {
            get
            {
                if (zooStages.Count>index)
                {
                    return zooStages[index];
                }
                else return null;
            }
        }
        //public List<string> getLevels
        //{
        //    get
        //    {
        //        return zooStages.Keys.ToList();
        //    }
        //}
        //public bool SaveData(string filename)
        //{
        //    if (File.Exists(filename))
        //    {
        //        File.Delete(filename);
        //    }
        //    using (FileStream fs = new FileStream(filename, FileMode.Create))
        //    {
        //        using (StreamWriter sr = new StreamWriter(fs))
        //        {

        //            sr.WriteLine("Kolichectvo:" + zooStages.Count);
        //            foreach (ZooStage<Animal> level in zooStages.Values)
        //            {
                        
        //                sr.WriteLine("Level");
        //                for (int i = 0; i < level.maxTig; i++)
        //                {
        //                    var tig = level.GetTig(i);
        //                    if (tig != null)
        //                    {
        //                        if (tig.GetType().Name == "Panther")
        //                        {
        //                            sr.Write("Panther:");
        //                        }
        //                        if (tig.GetType().Name == "ATiger")
        //                        {
        //                            sr.Write("ATiger:");
        //                        }
        //                        sr.WriteLine((tig as Animal).getInfo());
        //                    }
        //                }
        //            }
        //            sr.Write("End");
        //        }
        //    }
        //    return true;
        //}
        //public bool LoadData(string filename)
        //{
        //    if (!File.Exists(filename))
        //    {
        //        return false;
        //    }
        //    using (FileStream sr = new FileStream(filename, FileMode.Open))
        //    {
        //        string s = "";
        //        string[] strs; ;
        //        List<string> tmp = new List<string>();
        //        using (StreamReader bs = new StreamReader(sr))
        //        {
        //            string line;
        //           while ((line=bs.ReadLine())!=null)
        //            {
        //                tmp.Add(line);
        //            }
        //        }
        //        strs = tmp.ToArray();
        //        if (strs[0].Contains("Kolichectvo:"))
        //        {
        //            int count = Convert.ToInt32(strs[0].Split(':')[1]);
        //            if (zooStages != null)
        //            {
        //                zooStages.Clear();
        //            }
        //            zooStages = new Dictionary<string, ZooStage<Animal>>();
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //        int counter = -1;

        //        for (int i = 1; i < strs.Length; ++i)
        //        {
        //            if (strs[i] == "Level")
        //            {
        //                counter++;
        //                zooStages.Add("L"+(counter+1),new ZooStage<Animal>(null,"L"+(counter+1)));
        //            }
        //            else if (strs[i] == "End")
        //            {
        //                return true;
        //            }
        //            else if (strs[i].Split(':')[0] == "Panther")
        //            {
        //                var tig = new Panther(strs[i].Split(':')[1]);
        //                int number = zooStages["L" +(counter+1)] + tig;
        //                if (number == -1)
        //                {
        //                    return false;
        //                }
        //            }
        //            else if (strs[i].Split(':')[0] == "ATiger")
        //            {
        //                var tig = new ATiger(strs[i].Split(':')[1]);
        //                int number = zooStages["L" + (counter + 1)] + tig;
        //                if (number == -1)
        //                {
        //                    return false;
        //                }
        //            }
        //        }
        //    }
        //    return true;
        //}
    }
}
