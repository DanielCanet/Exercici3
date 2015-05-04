using System;

namespace Exercici3
{
    /// <summary>
    /// Valores especiales. Estos valores pueden ser leídos pero no modificados (la razón no es importante, quizá sean obtenidos de un servicio que no permite guardarlos, por ejemplo.
    /// </summary>
    public class SpecialSettings : IPersistResource
    {
        public void Load()
        {
            Console.WriteLine("Load SpecialSettings");
        }

        public void Persist()
        {
            throw new NotImplementedException();
        }
    }
}