using System;

namespace Exercici3
{
    /// <summary>
    /// Valores de usuario. La implementación concreta no es importante pero permiten ser leídos, modificados y escritos de nuevo.
    /// </summary>
    public class UserSettings : IPersistResource
    {
        public void Load()
        {
            Console.WriteLine("Load UserSettings");
        }

        public void Persist()
        {
            Console.WriteLine("Save UserSettings");
        }
    }
}