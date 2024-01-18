using System;

namespace FactoryMethod_Beer
{
    public class Bock : ILager
    {
        public string Name()
        {
            return "Style: Bock.";
        }
        public string Description()
        {
            return "Description: A strong, robust lager, often with notes of caramel. Una lager fuerte y robusta, a menudo con notas de caramelo.";
        }

        public string Origin()
        {
            return "Origin: Germany. Originally from the city of Einbeck, it was adapted in Munich. It is made in strong and malty versions. Alemania. Originaria de la ciudad de Einbeck, fue adaptada en Munich. Se elabora en versiones fuertes y maltosas.";
        }
    }
}