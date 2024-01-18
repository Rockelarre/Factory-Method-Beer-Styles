using FactoryMethod_Beer;

Console.WriteLine("----------------------");
Console.WriteLine("Beer Styles");
Console.WriteLine("---------------------- ");
Console.WriteLine("");

Console.WriteLine("----------------------");
Console.WriteLine("Ale Beers");
Console.WriteLine("---------------------- ");
Console.WriteLine("");

IAle paleale = AleFactory.CreateBeer("PaleAle");
Console.WriteLine(paleale.Name());
Console.WriteLine(paleale.Description());
Console.WriteLine(paleale.Origin());
Console.WriteLine("");

IAle indiapaleale = AleFactory.CreateBeer("IndiaPaleAle");
Console.WriteLine(indiapaleale.Name());
Console.WriteLine(indiapaleale.Description());
Console.WriteLine(indiapaleale.Origin());
Console.WriteLine("");

IAle stout = AleFactory.CreateBeer("Stout");
Console.WriteLine(stout.Name());
Console.WriteLine(stout.Description());
Console.WriteLine(stout.Origin());
Console.WriteLine("");

IAle porter = AleFactory.CreateBeer("Porter");
Console.WriteLine(porter.Name());
Console.WriteLine(porter.Description());
Console.WriteLine(porter.Origin());
Console.WriteLine("");

IAle amberale = AleFactory.CreateBeer("AmberAle");
Console.WriteLine(amberale.Name());
Console.WriteLine(amberale.Description());
Console.WriteLine(amberale.Origin());
Console.WriteLine("");

IAle brownale = AleFactory.CreateBeer("BrownAle");
Console.WriteLine(brownale.Name());
Console.WriteLine(brownale.Description());
Console.WriteLine(brownale.Origin());
Console.WriteLine("");

Console.WriteLine("----------------------");
Console.WriteLine("Lager Beers");
Console.WriteLine("---------------------- ");
Console.WriteLine("");

ILager pilsner = LagerFactory.CreateBeer("Pilsner");
Console.WriteLine(pilsner.Name());
Console.WriteLine(pilsner.Description());
Console.WriteLine(pilsner.Origin());
Console.WriteLine("");

ILager helles = LagerFactory.CreateBeer("Helles");
Console.WriteLine(helles.Name());
Console.WriteLine(helles.Description());
Console.WriteLine(helles.Origin());
Console.WriteLine("");

ILager bock = LagerFactory.CreateBeer("Bock");
Console.WriteLine(bock.Name());
Console.WriteLine(bock.Description());
Console.WriteLine(bock.Origin());
Console.WriteLine("");

ILager dunkel = LagerFactory.CreateBeer("Dunkel");
Console.WriteLine(dunkel.Name());
Console.WriteLine(dunkel.Description());
Console.WriteLine(dunkel.Origin());
Console.WriteLine("");

ILager maibok = LagerFactory.CreateBeer("Maibock");
Console.WriteLine(maibok.Name());
Console.WriteLine(maibok.Description());
Console.WriteLine(maibok.Origin());
Console.WriteLine("");