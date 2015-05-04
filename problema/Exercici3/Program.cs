using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercici3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----------------------");
            IEnumerable<IPersistResource> resources = LoadAll();
            Console.WriteLine("Loaded resources");

            // Trabajamos con los recursos, los modificamos, etc.
            Console.WriteLine("----------------------");

            SaveAll(resources);
            Console.WriteLine("Saved resources");
            Console.WriteLine("----------------------");
        }

        /// <summary>
        /// Carga los valores de configuración en una sola lista
        /// </summary>
        /// <returns>la lista de valores de configuración</returns>
        static IEnumerable<IPersistResource> LoadAll()
        {
            var allResources = new List<IPersistResource>()
            {
                new UserSettings(),
                new ApplicationSettings(),
                new SpecialSettings(),
            };

            foreach (IPersistResource resource in allResources)
            {
                resource.Load();
            }

            return allResources;
        }

        /// <summary>
        /// Graba los valores de configuración a su persistencia
        /// </summary>
        /// <param name="allResources">lista de valores a guardar</param>
        static void SaveAll(IEnumerable<IPersistResource> allResources)
        {
            foreach (IPersistResource resource in allResources)
            {
                resource.Persist();
            }
        }
    }
}
