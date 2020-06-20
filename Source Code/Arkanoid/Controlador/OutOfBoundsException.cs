using System;

namespace Arkanoid.Controlador
{
    public class OutOfBoundsException : Exception
    {
        public OutOfBoundsException(string Ex) : base(Ex)
        {
        }
    }
}