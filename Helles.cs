using System;

namespace FactoryMethod_Beer
{
    public class Helles : ILager
    {
        public string Name()
        {
            return "Style: Helles.";
        }
        public string Description()
        {
            return "Description: A clear and balanced German lager. Una lager alemana clara y equilibrada.";
        }

        public string Origin()
        {
            return "Origin: Germany. 'Helles' means 'clear' in German. This style of light lager became popular in Bavaria, Germany. Alemania. 'Helles' significa 'clara' en alemán. Este estilo de lager claro se volvió popular en Baviera, Alemania.";
        }
    }
}