using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Sharp.BuildBouqet
{
    public class BouqetBilder
    {
        private Bouqet _bouqet = new();

        public void BuildRose()
        {
            Flower rose = new Flower() { Name = "Rose", Price = 50m };
            _bouqet.Flowerlist.Add(rose);
            _bouqet.Price += rose.Price;
        }
        public void BuildChamomile()
        {
            Flower chamomlie = new Flower() { Name = "Chamomlie", Price = 40m };
            _bouqet.Flowerlist.Add(chamomlie);
            _bouqet.Price += chamomlie.Price;
        }
        public void BuildLavender()
        {
            Flower lavender = new Flower() { Name = "Lavender", Price = 45m };
            _bouqet.Flowerlist.Add(lavender);
            _bouqet.Price += lavender.Price;
        }
        public Bouqet GetBouqet() => _bouqet;
    }
}
