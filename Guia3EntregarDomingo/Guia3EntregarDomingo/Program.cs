using System.Linq.Expressions;
using System.Threading.Channels;

namespace Guia3EntregarDomingo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creamos una lista de los 3 empleados que tenemos
            List<Empleado> listaEmpleados = new List<Empleado>();

            listaEmpleados.Add(new Empleado("Juan", 101, 30000));
            listaEmpleados.Add(new Empleado("Maria", 102, 35000));
            listaEmpleados.Add(new Empleado("Pedro", 103, 32000));
            // nos ayudamos de un auxiliar
            foreach (var empleado in listaEmpleados)
            {
                empleado.MostrarDetalles();// llamamos el metodo mostrar detalles que obtiene los nombres,numempleado y su salario
            }
            //cambiamos el estado del empleado si queremos que sea activo o inactivo 
            int numeroEmpleadoCambiarEstado = 103;
            Empleado empleadoCambiarEstado = BuscarEmpleado(listaEmpleados, numeroEmpleadoCambiarEstado);
            
            if (empleadoCambiarEstado != null)
            {
                empleadoCambiarEstado.CambiarEstado(1);
                empleadoCambiarEstado.MostrarDetalles();
            }
            else// si llega a tener otro numero que no sea el de el no lo encontrara
            {
                Console.WriteLine($"Empleado con número {numeroEmpleadoCambiarEstado} no encontrado. ");
            }

        }//el metodo nos ayuda para buscar el empleado con el numero del empleado
        static Empleado BuscarEmpleado(List<Empleado> empleados, int numeroEmpleado)
        {
            foreach (var empleado in empleados)
            {

                if (empleado.ObtenerNumeroEmpleado() == numeroEmpleado)
                {

                    return empleado;
                }
               
            }
            return null;
        }


    }
}
