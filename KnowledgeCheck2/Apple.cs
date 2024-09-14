using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    internal class Apple : Fruit
    {
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}Price: {Price:C}";
        }
    }
}
