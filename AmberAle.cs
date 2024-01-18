using System;

namespace FactoryMethod_Beer
{
    public class AmberAle : IAle 
    {
        public string Name()
        {
            return "Style: Amber Ale.";
        }
        public string Description()
        {
            return "Description: An amber beer with a balance between malts and hops. Una cerveza de color ámbar con un equilibrio entre maltas y lúpulos.";
        }

        public string Origin()
        {
            return "Origin: United States, influenced by British traditions. Although it has roots in England, the American version is characterized by the use of American hops. Estados Unidos, influenciado por las tradiciones británicas. Aunque tiene raíces en Inglaterra, la versión americana se caracteriza por el uso de lúpulos americanos.";
        }
    }
}