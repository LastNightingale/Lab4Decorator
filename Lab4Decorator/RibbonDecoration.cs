using System;
using System.Collections.Generic;
using Lab4Sharp.BuildBouqet;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Sharp.DecorateBouqet
{
    internal class RibbonDecoration : Decoration
    {
        public RibbonDecoration()
        {
            DecorationName = "Іменована стрічка";
            Price = 5m;
        }
    }
}
