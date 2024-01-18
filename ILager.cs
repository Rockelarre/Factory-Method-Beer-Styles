using System;

namespace FactoryMethod_Beer
{
    public interface ILager
    {
        string Name();
        string Description();
        string Origin();
    }
}