using System;
using System.Collections.Generic;
using Lab4Sharp.BuildBouqet;

namespace Lab4Sharp.DecorateBouqet
{
    internal class BroochDecorator : BouqetDecorator
    {
        public BroochDecorator(IBouqet bouqet) : base(bouqet)
        {
            _decoration = new BroochDecoration();
        }
                
    }
}
