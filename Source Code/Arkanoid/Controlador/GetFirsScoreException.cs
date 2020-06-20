using System;

namespace Arkanoid.Controlador
{
    public class GetFirsScoreException: Exception
    {
        public GetFirsScoreException(string Ex) : base(Ex)
        {
        }
    }
}