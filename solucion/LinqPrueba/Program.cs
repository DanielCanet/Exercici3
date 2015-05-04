using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LinqPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Curso> cursos = new List<Curso>();
            List<Estudiante> estudiantes = new List<Estudiante>(); 

            cursos.Add(new Curso(){ IdCurso = 1, Description = "Curso 1"});
            cursos.Add(new Curso() { IdCurso = 2, Description = "Curso 2" });
            cursos.Add(new Curso() { IdCurso = 3, Description = "Curso 3" });

            estudiantes.Add(new Estudiante(){ IdCurso = 1, IdEstudiante = 1, Name = "Pepito"});
            estudiantes.Add(new Estudiante() { IdCurso = 1, IdEstudiante = 2, Name = "Manolo" });
            estudiantes.Add(new Estudiante() { IdCurso = 2, IdEstudiante = 4, Name = "Peliqueiro" });
            estudiantes.Add(new Estudiante() { IdCurso = 3, IdEstudiante = 5, Name = "Jose" });
            estudiantes.Add(new Estudiante() { IdCurso = 3, IdEstudiante = 6, Name = "Ivan" });


            List<EstudianteDTO> lista3 =
                estudiantes.Join(cursos, e => e.IdCurso, c => c.IdCurso, (e, c) => new EstudianteDTO()
                {
                    IdCurso = e.IdCurso,
                    Description = c.Description,
                    Name = e.Name

                }).Where(r => r.IdCurso == 1).ToList();

            Action<EstudianteDTO> del = Console.WriteLine;
            
            lista3.ForEach(ImprimirEstudiante);
            Console.WriteLine("\n");
            lista3.ForEach(del);
            Console.ReadKey();
        }

        private static void ImprimirEstudiante(EstudianteDTO estudiante)
        {
            Console.WriteLine(estudiante);
        } 
    }
}
