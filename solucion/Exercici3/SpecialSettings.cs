using System;

namespace Exercici3
{
    /// <summary>
    /// Valores especiales. Estos valores pueden ser leídos pero no modificados (la razón no es importante, quizá sean obtenidos de un servicio que no permite guardarlos, por ejemplo.
    /// </summary>
    public class SpecialSettings : IPersistResource, Iinterface2
    {
        public void Load()
        {
            Console.WriteLine("Load SpecialSettings");
        }

        public void Persist()
        {
            throw new NotImplementedException();
        }

        public void Metodo1()
        {
            throw new NotImplementedException();
        }
    }

    class MyClass
    {
        static readonly SpecialSettings settings = new SpecialSettings();

        private IPersistResource obj1 = (IPersistResource) settings;
        private Iinterface2 obj2 = (Iinterface2)settings;

        private void prueba()
        {
            obj2.Metodo1();
        }

    }

    public interface Iinterface2
    {
        void Metodo1();
    }
}