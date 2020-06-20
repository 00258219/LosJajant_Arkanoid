using System;

namespace Arkanoid.Controlador
{
    public class GetDataException : Exception
    {
        public GetDataException(string Ex) : base(Ex)
        {
        }
    }
}