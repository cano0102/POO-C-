using System;

namespace ConsoleApp
{
    internal class Mascota
    {
        private string _Nombre { get; set; }
        private int _Edad { get; set; }

        private string _Tipo { get; set; }

        private float _Peso { get; set; }



        public Mascota(string Nombre, int Edad , string Tipo , float Peso)
        {
            _Nombre = Nombre;
            _Edad = Edad;
            _Tipo = Tipo;
            _Peso = Peso;

        }

        protected void MoatrarInfo()
        {
             Console.WriteLine($"Nombre: {_Nombre}, Edad: {_Edad}, Tipo: {_Tipo}, Peso: {_Peso}");
        }


        public void CalcularEdadHumana()
        {

            if (_Tipo == "perro" )
            {
                int edad = _Edad * 7;
                
               

            }
            else
            {
                if (_Tipo == "gato")
                {
                    int edad = _Edad * 7;
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        public void AccerderAMetodo()
        {
            MoatrarInfo();
        }






    }
    
  

}