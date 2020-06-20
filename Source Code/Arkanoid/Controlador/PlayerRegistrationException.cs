using System;

namespace Arkanoid.Controlador
{
    public class PlayerRegistrationException : Exception
    {
        public PlayerRegistrationException(string Ex) : base(Ex)
        {
        }

    }
}