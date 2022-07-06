using System;
using System.Text;
using System.Collections.Generic;
using Lab4Sharp.BuildBouqet;

namespace Lab4Sharp.DecorateBouqet
{
    public abstract class BouqetDecorator : IBouqet
    {
        protected IBouqet _bouqet;

        protected Decoration _decoration;
        public decimal Price => _decoration.Price + _bouqet.Price;
        public BouqetDecorator(IBouqet bouqet)
        {
            _bouqet = bouqet;
        }       

        public override string ToString()
        {
            return new StringBuilder(_bouqet.ToString())
                .AppendLine($"{_decoration.DecorationName}: {_decoration.Price}")
                .ToString();
        }
    }
}
