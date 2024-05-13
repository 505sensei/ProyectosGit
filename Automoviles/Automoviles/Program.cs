namespace Automoviles
{
    partial class Automovil
    {
        static void Main(string[] args)
        {

            Automovil automovil = new Automovil("Toyota ","M45615","Supra","Rojo",100,0,900);

            Console.WriteLine($"Marca: {automovil.Marca}");
            Console.WriteLine($"Placa: {automovil.Placa}");
            Console.WriteLine($"Marca: {automovil.Modelo}");
            Console.WriteLine($"Placa: {automovil.Color}");
            Console.WriteLine($"Capacidad Del Tanque de Combustible: {automovil.CapacidadTanqueCombustible}");
            Console.WriteLine($"Nivel del Combustible: {automovil.NivelCombustible}");
            Console.WriteLine($"Rendimiento del Combustible: {automovil.RendimientoCombustible}");

            int distancia = 900;

            if (automovil.Conducir(distancia))
            {

                Console.WriteLine($"Puede Conducir esa distancia {distancia}");
            }
            else {
                Console.WriteLine($"No puede conducir cierta distancia {distancia}");
            }

            double cantidadDeRellenar = 30.00;
            automovil.Rellenar(cantidadDeRellenar);
            Console.WriteLine($"Se relleno el tanque de combustible: {cantidadDeRellenar}");
            Console.WriteLine($"Nivel de combustible actual despues de rellenarlo: {automovil.NivelCombustible}");


        }
    }
}
