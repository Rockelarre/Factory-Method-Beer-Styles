using System;

namespace FactoryMethod_Beer
{
    public class Stout : IAle 
    {
        public string Name()
        {
            return "Style: Stout.";
        }
        public string Description()
        {
            return "Description: A dark, roasty beer with coffee and chocolate flavors. Una cerveza oscura y tostada con sabores a café y chocolate.";
        }

        public string Origin()
        {
            return "Origin: England, 18th century. Originally known as a 'stout porter,' it was created as a stronger, darker version of traditional porters. Inglaterra, siglo XVIII. Originalmente conocida como 'stout porter', se creó como una versión más fuerte y oscura de las porters tradicionales.";
        }
    }
}