using System;
using System.Collections.Generic;
using Lab4Sharp.BuildBouqet;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Sharp.DecorateBouqet
{
    internal class RibbonDecorator : BouqetDecorator
    {
        public RibbonDecorator(IBouqet bouqet) : base(bouqet)
        {
            _decoration = new RibbonDecoration();
        }
    }
}
