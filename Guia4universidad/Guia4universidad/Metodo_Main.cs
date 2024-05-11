using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4universidad
{
    internal class Metodo_Main
    {
        public static void Main(string[]args) {
            //llamamos al objeto universidad y le damos su nombre
            Universidad universidad = new Universidad();
            //igual que la universidad llamamos al Alumno y le damos su nombre edad carrera y carnet
            Alumno alumno = new Alumno("Ernesto",20,Alumno.Carreras.Ingieneria_de_Sistema,"2023-0954U");
            //me agregan a la universidad
            universidad.AgregarAlumno(alumno);
            //usamos el foreach para mostrar la lista de alumnos
            foreach (var estudiante in universidad.ObtenerListaAlumno())
            {
                Console.WriteLine($"Nombre{estudiante.Nombre } edad del alumno{estudiante.Edad}, su carrera{estudiante.Carrera},su carnet{estudiante.Carné}");
            }
            //si el alumno aprobo o desaprobo
            Console.WriteLine($"Estado del alumno: {alumno.EstadoAprobacion()}");
            

        }
    }
}
