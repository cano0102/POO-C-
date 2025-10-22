// ejercicio1.cs
// Ejemplo básico para "importar" (usar) una clase definida en otro archivo .cs
// - Agrega OtherClass.cs al mismo proyecto.
// - Si OtherClass está en otro namespace, ajusta el using.

using System;


namespace MiProyecto.App
{
    // Programa de ejemplo que usa la clase/método definido en Ejercicios.cs
    class Program
    {
        static void Main(string[] args)
        {

            // Llamada a un método estático definido en otro archivo del mismo proyecto
            // Actividad es una clase static/internal en el namespace Ejercicios,
            // por lo que podemos llamar directamente a su método estático.
            // Prestamo.MostrarPrestamo();
            // Salario.MostrarSalario();
            // Objetos.CrearPersona();




            // Crear la clase "Libro" tiene los atributos "Titulo", "Autor", "Editorial" y "AnioPublicacion",
            // que se definen en el constructor de la clase. La clase "Biblioteca" contiene una lista de
            // objetos "Libro", que se pueden agregar mediante el método "AgregarLibro" y listar mediante
            // el método "ListarLibros". En el método, un método para buscar el libro por su nombre.
            // "Main", se muestra un menú de opciones.

            Biblioteca biblioteca = new Biblioteca();
            while (true)
            {

                Console.WriteLine("\n MENÚ DE BIBLIOTECA ");
                Console.WriteLine("1. Agregar libro");
                Console.WriteLine("2. Listar libros");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {

                    case 1:
                        biblioteca.AgregarLibro();
                        break;
                    case 2:
                        biblioteca.ListarLibros();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa");
                        break;

                    default:
                        Console.WriteLine("OPcion no validad");
                        break;


                }

            }
        }
    }
}