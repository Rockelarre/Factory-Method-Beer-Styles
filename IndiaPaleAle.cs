using System;

namespace FactoryMethod_Beer
{
    public class IndiaPaleAle : IAle 
    {
        public string Name()
        {
            return "Style: India Pale Ale (IPA).";
        }
        public string Description()
        {
            return "Description: A style of Pale Ale with a higher hop content, known for its bitterness and floral/fruity aroma. Un estilo de Pale Ale con un mayor contenido de lúpulo, conocido por su amargor y aroma floral/frutal.";
        }

        public string Origin()
        {
            return "Origin: England, 18th century. The IPA style was developed to ship beer to India during the time of the British Empire. It was made with more hops and alcohol to withstand the long journey. Inglaterra, siglo XVIII. El estilo IPA se desarrolló para enviar cerveza a la India durante la época del Imperio Británico. Se elaboraba con más lúpulo y alcohol para resistir el largo viaje.";
        }
    }
}