using Lab4Sharp.BuildBouqet;
using Lab4Sharp.DecorateBouqet;

Console.OutputEncoding = System.Text.Encoding.Unicode;
BouqetBilder bilder = new BouqetBilder();
bilder.BuildRose();
bilder.BuildChamomile();
bilder.BuildLavender();
Bouqet bouqet = bilder.GetBouqet();
Console.WriteLine(bouqet);
RibbonDecorator decorator = new RibbonDecorator(bouqet);
Console.WriteLine(decorator);
WarpDecorator warpDecorator = new WarpDecorator(decorator);
Console.WriteLine(warpDecorator);
BroochDecorator broochDecorator = new BroochDecorator(warpDecorator);
Console.WriteLine(broochDecorator);
Console.WriteLine($"Загальна ціна: {broochDecorator.Price}");

