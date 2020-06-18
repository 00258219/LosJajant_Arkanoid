using System;

namespace Arkanoid.Modelo
{
    public class GetPlayerException : Exception
    {
        public GetPlayerException(string Ex) : base(Ex)
        {
        }
    }
}