using System;
using System.Collections.Generic;
using Lab4Sharp.BuildBouqet;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Sharp.DecorateBouqet
{
    internal class WarpDecorator : BouqetDecorator
    {
        public WarpDecorator(IBouqet bouqet) : base(bouqet)
        {
            _decoration = new WarpDecoration();
        }
    }
}
