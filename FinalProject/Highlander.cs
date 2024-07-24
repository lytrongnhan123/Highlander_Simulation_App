using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Highlander
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int PowerLevel { get; set ; }
        public bool isGood { get; set; }
        
        public Position Pos { get; set; }
        public Highlander() { }

    }
}
