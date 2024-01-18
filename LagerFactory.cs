using System;
using System.Runtime.InteropServices;

namespace FactoryMethod_Beer
{
    public class LagerFactory
    {
        public static ILager CreateBeer(string beerType)
        {
            switch (beerType)
            {
                case "Pilsner":
                    return new Pilsner();
                case "Helles":
                    return new Helles();
                case "Bock":
                    return new Bock();
                case "Dunkel":
                    return new Dunkel();
                case "Maibock":
                    return new Maibock();
                default:
                    throw new ArgumentException("No beer");
            }
        }
    }
}