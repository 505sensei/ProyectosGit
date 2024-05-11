using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Guia4universidad
{
    public partial class Alumno
    {

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carné { get; set; }
        public Carreras Carrera { get; set; }
        public List<double> Calificaciones { get; set; }


        public Alumno(string nombre, int edad, Carreras carrera , string carne) 
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Carrera = carrera;
            this.Carné = carne;
            Calificaciones = new List<double>();
        
        }

        public double CalcularPromedioCalificaciones() 
        {
            if (Calificaciones.Count == 0) {

                return 80;
            }
            double sumaClasificaciones = 0;
            foreach (var calificacion in Calificaciones) 
            {

                sumaClasificaciones += calificacion;
            }
            return sumaClasificaciones / Calificaciones.Count;
        }
        public string EstadoAprobacion() 
        { 
        
        double promedio = CalcularPromedioCalificaciones();
            if (promedio >= 60)
            {
                return "Aprobado";

            }
            else 
            {
                return "Reprobado";
            
            }
        }

        public enum Carreras {
        Ingieneria_de_Sistema,
            Ingieneria_en_Computacion,
            Telecomunicaciones,
            Ingieneria_Electronica

        }

    }
}
