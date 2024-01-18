using System;

namespace FactoryMethod_Beer
{
    public class Porter : IAle 
    {
        public string Name()
        {
            return "Style: Porter.";
        }
        public string Description()
        {
            return "Description: Similar to a Stout, but often lighter. Similar a una Stout, pero a menudo más ligera.";
        }

        public string Origin()
        {
            return "Origin: England, 18th century. It was born in the London beer scene and was a popular beer among dock workers, hence its name. Inglaterra, siglo XVIII. Nació en la escena cervecera londinense y fue una cerveza popular entre los trabajadores portuarios, de ahí su nombre.";
        }
    }
}