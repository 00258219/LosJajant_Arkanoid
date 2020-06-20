using System;

namespace Arkanoid.Controlador
{
    public class GetPlayerException : Exception
    {
        public GetPlayerException(string Ex) : base(Ex)
        {
        }
    }
}