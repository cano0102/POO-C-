using System;

namespace ConsoleApp
{
        internal class Aprendiz
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Direccion { get; set; }


            public Aprendiz(string Nombre, int Edad, string Direccion)
            {
                this.Nombre = Nombre;
                this.Edad = Edad;
                this.Direccion = Direccion;

            }

            public void VerrificarEdad()
            {
                if (Edad >= 18 )
                {
                 Console.WriteLine($"Eres mayor de edad {Nombre}");
                }
                else
                {
                    Console.WriteLine($"No eres mayor de edad {Nombre}");
                }

            }
        }
    
}