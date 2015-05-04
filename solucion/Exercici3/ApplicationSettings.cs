using System;

namespace Exercici3
{
    /// <summary>
    /// Valores de aplicaci�n. La implementaci�n concreta no es importante pero permiten ser le�dos, modificados y escritos de nuevo.
    /// </summary>
    public class ApplicationSettings : IPersistResource
    {

        public void Load()
        {
            Console.WriteLine("Load ApplicationSettings");
        }

        public void Persist()
        {
            Console.WriteLine("Save ApplicationSettings");
        }
    }
}