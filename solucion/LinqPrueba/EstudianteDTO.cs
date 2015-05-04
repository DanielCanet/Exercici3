using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPrueba
{
    public class EstudianteDTO
    {
        public int IdEstudiante { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int IdCurso { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
