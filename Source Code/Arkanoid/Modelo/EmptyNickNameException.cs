using System;

namespace Arkanoid.Modelo
{
    public class EmptyNickNameException : Exception
    {
        public EmptyNickNameException(string Ex) : base(Ex)
        {
        }
    }
}