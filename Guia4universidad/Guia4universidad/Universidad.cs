using System.Security.Cryptography.X509Certificates;

namespace Guia4universidad
{

     public partial class Universidad
     {

        private List<Alumno> listaAlumnos;

        public Universidad()
        {
            listaAlumnos = new List<Alumno>();
        }

        public void AgregarAlumno(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
        }

        public List<Alumno> ObtenerListaAlumno()
        {

            return listaAlumnos;
        }

     }
    
} 
  

   



