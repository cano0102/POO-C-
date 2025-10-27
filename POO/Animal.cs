using System;

namespace ConsoleApp
{
    internal class Animal
    {
        public string _Nombre { get; set; }
        protected string _Especie { get; set; }



        public Animal(string Nombre, string Especie)
        {
            _Nombre = Nombre;
            _Especie = Especie;

        }

        protected void MoatrarInfo()
        {
            Console.WriteLine($"Nombre: {_Nombre} , Edad {_Especie}");
        }

        public void AccerderAMetodo()
        {
            MoatrarInfo();
        }






    }
    
    internal class Perro : Animal
    {
        public string Raza { get; set; }


        public Perro(string Nombre, string Especie, string Raza)
            : base(Nombre, Especie)
        {
            this.Raza = Raza;
        }


        public void MostrarDatos()
        {
            AccerderAMetodo();
            Console.WriteLine($"Raza: {Raza}");
        }
    }

}