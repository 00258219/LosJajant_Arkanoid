using System;

namespace Arkanoid.Controlador
{
    public class GamePausedException : Exception
    {
        public GamePausedException(string Ex):base(Ex){}
    }
}