using System;

namespace FactoryMethod_Beer
{
    public class PaleAle : IAle 
    {
        public string Name()
        {
            return "Style: Pale Ale.";
        }
        public string Description()
        {
            return "Description: A pale beer with a hop flavor. Una cerveza pálida con sabor a lúpulo.";
        }

        public string Origin()
        {
            return "Origin: England, specifically in the 18th century. It was an evolution of the darker, maltier beers that were brewed at that time. Inglaterra, específicamente en el siglo XVIII. Fue una evolución de las cervezas más oscuras y maltosas que se elaboraban en esa época.";
        }
    }
}