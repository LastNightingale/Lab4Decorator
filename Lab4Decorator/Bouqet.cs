using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Sharp.BuildBouqet
{
    public class Bouqet : IBouqet
    {
        public List<Flower> Flowerlist = new();

        public decimal Price { get; set; }

        public override string ToString()
        {
            var bouqet = new StringBuilder();
            foreach (Flower flower in Flowerlist)
            {
                bouqet.Append(flower.ToString());
            }
            return bouqet.ToString();
        }
    }
}
