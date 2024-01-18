using System;

namespace FactoryMethod_Beer
{
    public class Pilsner : ILager
    {
        public string Name()
        {
            return "Style: Pilsner.";
        }
        public string Description()
        {
            return "Description: A lager beer with a light color and refreshing flavor. Una cerveza lager de color claro y sabor refrescante.";
        }

        public string Origin()
        {
            return "Origin: Czech Republic, city of Pilsen. It was created by the brewer Josef Groll in 1842, marking the beginning of pilsner-type beers. República Checa, ciudad de Pilsen. Fue creada por el cervecero Josef Groll en 1842, marcando el inicio de las cervezas tipo pilsner.";
        }
    }
}