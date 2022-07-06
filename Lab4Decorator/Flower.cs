using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Sharp.BuildBouqet
{
    public class Flower
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Квітка:{Name}, Вартість:{Price}" + "\n";
        }
    }
}
