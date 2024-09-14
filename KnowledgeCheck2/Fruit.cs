using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    internal class Fruit
    {
        public String Name { get; set; }
        public double WeightInPounds { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}\nWeight: {WeightInPounds} lbs\n";
        }
    }
}
