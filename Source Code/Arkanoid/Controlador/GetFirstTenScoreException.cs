using System;

namespace Arkanoid.Controlador
{
    public class GetFirstTenScoreException: Exception
    {
        public GetFirstTenScoreException(string Ex) : base(Ex)
        {
        }
    }
}