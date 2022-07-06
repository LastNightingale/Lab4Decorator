using System;
using System.Collections.Generic;
using Lab4Sharp.BuildBouqet;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Sharp.DecorateBouqet
{
    internal class WarpDecoration : Decoration
    {
        public WarpDecoration()
        {
            DecorationName = "Обгортка";
            Price = 15m;
        }
    }
}
