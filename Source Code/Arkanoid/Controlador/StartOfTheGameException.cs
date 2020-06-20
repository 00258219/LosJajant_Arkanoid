using System;

namespace Arkanoid.Controlador
{
    public class StartOfTheGameException : Exception
    {
        public StartOfTheGameException(string Ex) : base(Ex)
        {
        }
    }
}