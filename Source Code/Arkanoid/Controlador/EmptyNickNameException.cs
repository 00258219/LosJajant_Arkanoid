using System;

namespace Arkanoid.Controlador
{
    public class EmptyNickNameException : Exception
    {
        public EmptyNickNameException(string Ex) : base(Ex)
        {
        }
    }
}