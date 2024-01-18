using System;
using System.Runtime.InteropServices;

namespace FactoryMethod_Beer
{
    public class AleFactory
    {
        public static IAle CreateBeer(string beerType)
        {
            switch (beerType)
            {
                case "PaleAle":
                    return new PaleAle();
                case "IndiaPaleAle":
                    return new IndiaPaleAle();
                case "BrownAle":
                    return new BrownAle();
                case "AmberAle":
                    return new AmberAle();
                case "Porter":
                    return new Porter();
                case "Stout":
                    return new Stout();
                default:
                    throw new ArgumentException("No beer");
            }
        }
    }
}