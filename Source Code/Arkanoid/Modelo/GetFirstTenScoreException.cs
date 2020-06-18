using System;

namespace Arkanoid.Modelo
{
    public class GetFirstTenScoreException: Exception
    {
        public GetFirstTenScoreException(string Ex) : base(Ex)
        {
        }
    }
}