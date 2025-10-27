using System;

namespace ConsoleApp
{
    internal class Persona
    {
        public string _Nombre { get; set; }
        private int _Edad { get; set; }



        public Persona(string Nombre, int Edad)
        {
            _Nombre = Nombre;
            _Edad = Edad;

        }

        private void MoatrarInfo()
        {
            Console.WriteLine($"Nombre{_Nombre} , Edad {_Edad}");
        }

        public void AccerderAMetodo()
        {
            MoatrarInfo();
        }

         




    }

}