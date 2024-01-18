using System;

namespace FactoryMethod_Beer
{
    public class Maibock : ILager
    {
        public string Name()
        {
            return "Style: Maibock.";
        }
        public string Description()
        {
            return "Description: A bock lager released in May, often lighter and stronger than traditional Bock. Una lager bock lanzada en mayo, a menudo más clara y más fuerte que la Bock tradicional.";
        }

        public string Origin()
        {
            return "Origin: Germany. A variant of the Bock, traditionally released in May. It is clearer and stronger than traditional Bock. Alemania. Una variante de la Bock, lanzada tradicionalmente en mayo. Es más clara y fuerte que la Bock tradicional.";
        }
    }
}