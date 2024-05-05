using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Guia3EntregarDomingo
{
    internal class Empleado
    {
        private string nombre;
        private int numeroEmpleado ;
        private decimal salario;
        private bool activo ;
        //creamos un metodo que obtendra los private para no tener el error en la clase Empleado
        public Empleado(string nombre, int numeroEmpleado, decimal salario) {
            this.nombre = nombre;
            this.numeroEmpleado = numeroEmpleado;
            this.salario = salario;
            this.activo = true;
        }

        //creamos el metodo MostrarDetalles obtenemos el nombre, numempleado,salario y su esatdo
        public void MostrarDetalles() {

            string estado = (activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {nombre}, Numero de empleado: {numeroEmpleado}, salario: {salario:c}, estado{estado}");
        }
        //obtenemos el numero de empleado 
        public int ObtenerNumeroEmpleado()
        {
            return this.numeroEmpleado;
        }
        //creamos un metodo con parametro para cambiar el estado del empleado si esta acivado o desactivado activo e inactivo
        public void CambiarEstado(int nuevoEstado)
        {
            if (nuevoEstado == 1)
            {
                activo = true;
                Console.WriteLine("Empleado activado");
            }
            else if (nuevoEstado == 0)
            {
                activo = false;
                Console.WriteLine("Empleado desactivado");
            }
            else {

                Console.WriteLine("Estado no valido. ");
            }

        }




    }
}
       
    

