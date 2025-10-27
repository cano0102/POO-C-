using System;

namespace ConsoleApp
{
        internal class Auto
        {
            public string Marca { get; set; }
            public int Anio { get; set; }
            public string Modelo { get; set; }


            public Auto(string Marca, int Anio, string Modelo)
            {
                this.Marca = Marca;
                this.Modelo = Modelo;
                this.Anio = Anio;

            }

            public void MostrarInfo()
            {
                Console.WriteLine($"Marca {Marca} Anio {Anio} Modelo {Modelo} ");

            }
        }
    
}