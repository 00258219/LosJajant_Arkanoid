using System;

namespace Arkanoid.Modelo
{
    public class PlayerRegistrationException : Exception
    {
        public PlayerRegistrationException(string Ex) : base(Ex)
        {
        }

    }
}