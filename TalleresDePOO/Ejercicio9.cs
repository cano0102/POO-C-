using System;

namespace ConsoleApp2
{
    internal class Mascota
    {
        // Campos privados
        private string Nombre;
        private int Edad;
        private string Tipo;

        // Método para establecer valores
        public void Establecer(string nombre, int edad, string tipo)
        {
            Nombre = nombre;
            Edad = edad;
            Tipo = tipo.ToLower(); // Guardamos en minúscula para comparar más fácil
        }

        // Método privado para mostrar datos básicos
        private void Obtener()
        {
            Console.WriteLine($"NOMBRE: {Nombre}");
            Console.WriteLine($"EDAD: {Edad} años");
            Console.WriteLine($"TIPO: {Tipo}");
        }

        // Método para validar tipo y calcular edad humana según el tipo
        private int CalcularEdadHumana()
        {
            int edadHumana = 0;

            switch (Tipo)
            {
                case "perro":
                    edadHumana = Edad * 7; // 1 año perro ≈ 7 años humanos
                    break;
                case "gato":
                    edadHumana = Edad * 5; // 1 año gato ≈ 5 años humanos
                    break;
                default:
                    edadHumana = Edad; // Otros animales: sin conversión
                    break;
            }

            return edadHumana;
        }

        // Método público para mostrar toda la información
        public void MostrarInformacion()
        {
            Obtener();
            Console.WriteLine($"EDAD EQUIVALENTE HUMANA: {CalcularEdadHumana()} años humanos");
        }
    }

    // Programa principal para probar la clase
    internal class Program
    {
        static void Main(string[] args)
        {
            Mascota m1 = new Mascota();

            Console.Write("Ingrese el nombre de la mascota: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la edad de la mascota (en años): ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tipo de mascota (perro, gato u otro): ");
            string tipo = Console.ReadLine();

            m1.Establecer(nombre, edad, tipo);

            Console.WriteLine("\n--- INFORMACIÓN DE LA MASCOTA ---");
            m1.MostrarInformacion();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
