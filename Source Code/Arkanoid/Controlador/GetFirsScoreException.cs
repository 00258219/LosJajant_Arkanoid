using System;

namespace Arkanoid.Modelo
{
    public class GetFirsScoreException: Exception
    {
        public GetFirsScoreException(string Ex) : base(Ex)
        {
        }
    }
}