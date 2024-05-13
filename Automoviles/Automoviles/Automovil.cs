using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Automoviles
{
    public partial class Automovil
    {

        public string Marca { get; set; } = "Toyota";
        public string Placa { get; set; }= "M12542";
        public string Modelo { get; set; } = "Supra";
        public string Color { get; set; } = "Rojo";
        public int CapacidadTanqueCombustible { get; set; } = 100;
        public double NivelCombustible { get; set; } = 0;
        public int RendimientoCombustible { get; set; } = 900;

        public Automovil(string marca,string placa,string modelo,string color,int capacidadtanquecombustible,int nivelcombustible,int rendimientocombustible)
        {
            Marca = marca;
            Placa = placa;
            Modelo = modelo;
            Color = color;
            CapacidadTanqueCombustible = capacidadtanquecombustible;
            NivelCombustible = nivelcombustible;
            RendimientoCombustible = rendimientocombustible;
        }
        public bool Conducir(int Distancia) {
            double CombustibleNecesarario = Distancia / RendimientoCombustible;
            return CombustibleNecesarario <= NivelCombustible;
        }

        public double Rellenar(double cantidad)
        {
            if (NivelCombustible + cantidad > CapacidadTanqueCombustible)
            {
                Console.WriteLine("No puede");
            }
            else {
                Console.WriteLine("Si puede");
            }
           return NivelCombustible+= cantidad;
        }
        public int PuedeConducir(int Distancia) {
            if (Distancia == 0)
            {
                Console.WriteLine("puede conducir");
                NivelCombustible -= NivelCombustible;
            }
            else {
                Console.WriteLine("No puede conducir");
            }
        return Distancia;
        }
    }
}