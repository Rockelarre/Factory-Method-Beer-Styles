using System;

namespace FactoryMethod_Beer
{
    public class BrownAle : IAle 
    {
        public string Name()
        {
            return "Style: Brown Ale.";
        }
        public string Description()
        {
            return "Description: A brown beer with malt and nutty flavors. Una cerveza de color marrón con sabores a malta y nuez.";
        }

        public string Origin()
        {
            return "Origin: England, 17th century. It originated as a darker variant of pale ales. Inglaterra, siglo XVII. Se originó como una variante más oscura de las pale ales.";
        }
    }
}