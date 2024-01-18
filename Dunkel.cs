using System;

namespace FactoryMethod_Beer
{
    public class Dunkel : ILager
    {
        public string Name()
        {
            return "Style: Dunkel.";
        }
        public string Description()
        {
            return "Description: A dark, malty lager. Una lager oscura y maltosa.";
        }

        public string Origin()
        {
            return "Origin: Germany. 'Dunkel' means 'dark' in German. It is a dark lager with a profile of rich, toasted malts. Alemania. 'Dunkel' significa 'oscuro' en alemán. Es una lager oscura con un perfil de maltas ricas y tostadas.";
        }
    }
}