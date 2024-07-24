using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class HighlandersGeneration
    {
        private static Random random = new Random();
        public List<Highlander> GoodSide { get; set; } = new List<Highlander>();
        public List<Highlander> BadSide { get; set; } = new List<Highlander>();



        public HighlandersGeneration(int quantity)
        {
            for (int i=0; i<quantity; i++)
            {
                Highlander goodHighLander = GenerateHighlander(true, i);
                Highlander badHighLander = GenerateHighlander(false, i);

                GoodSide.Add(goodHighLander);
                BadSide.Add(badHighLander);
            }
        }
        public Highlander GenerateHighlander(bool isGood, int index)
        {
            Highlander highlander = new Highlander();
            List<string> names = NameList();
           
            if (isGood)
            {
                highlander.Id = "G" + Convert.ToString(index);
            }
            else
            {
                highlander.Id = "B" + Convert.ToString(index);
            }

            int temp = random.Next(names.Count());
            highlander.Name = names[temp];
            highlander.Age = random.Next(30, 200);
            highlander.PowerLevel = highlander.Age * 100;
            highlander.isGood = isGood;
            return highlander;
        }
        internal List<string> NameList()
        {
            List<string> list = new List<string>();
            list.Add("Tom");
            list.Add("John");
            list.Add("Michael");
            list.Add("Peter");
            list.Add("Kevin");
            list.Add("Messi");
            list.Add("Ronaldo");
            list.Add("Martinez");
            list.Add("Ahmed");
            list.Add("Shota");
            list.Add("Elizabeth");
            list.Add("Sakura");
            list.Add("Naruto");
            list.Add("Sasuke");
            list.Add("Goku");
            list.Add("Luffy");
            list.Add("Vegeta");
            list.Add("Son Hueng Min");
            list.Add("Ojina");
            list.Add("Jose");
            list.Add("Zoro");
            return list;

        }


    }
}
