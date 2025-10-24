// ejercicio1.cs
// Ejemplo básico para "importar" (usar) una clase definida en otro archivo .cs
// - Agrega OtherClass.cs al mismo proyecto.
// - Si OtherClass está en otro namespace, ajusta el using.

using System;
using ConsoleApp;


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




            // // Crear la clase "Libro" tiene los atributos "Titulo", "Autor", "Editorial" y "AnioPublicacion",
            // // que se definen en el constructor de la clase. La clase "Biblioteca" contiene una lista de
            // // objetos "Libro", que se pueden agregar mediante el método "AgregarLibro" y listar mediante
            // // el método "ListarLibros". En el método, un método para buscar el libro por su nombre.
            // // "Main", se muestra un menú de opciones.

            // Biblioteca biblioteca = new Biblioteca();
            // bool continuar = true;
            // while (continuar)
            // {

            //     Console.WriteLine("\n MENÚ DE BIBLIOTECA ");
            //     Console.WriteLine("1. Agregar libro");
            //     Console.WriteLine("2. Listar libros");
            //     Console.WriteLine("3. Salir");
            //     Console.Write("Elige una opción: ");

            //     int opcion = int.Parse(Console.ReadLine());

            //     switch (opcion)
            //     {

            //         case 1:
            //             biblioteca.AgregarLibro();
            //             break;
            //         case 2:
            //             biblioteca.ListarLibros();
            //             break;
            //         case 3:
            //             Console.WriteLine("Saliendo del programa");
            //             continuar = false
            //             break;

            //         default:
            //             Console.WriteLine("OPcion no validad");
            //             break;


            //     }

            // }

            //Ejercicio 5


            // Estudiante estudiante = new Estudiante("alvarez mocholo", 19);
            // ProgramaAcademico programa1 = new ProgramaAcademico(1, "Ingenieria de sistemas", 20, 0.18F);
            // ProgramaAcademico programa2 = new ProgramaAcademico(2, "Psicologia", 16, 0.12F);
            // ProgramaAcademico programa3 = new ProgramaAcademico(3, "Economia", 18, 0.10F);
            // ProgramaAcademico programa4 = new ProgramaAcademico(4, "Comuniacion social", 18, 0.05F);
            // ProgramaAcademico programa5 = new ProgramaAcademico(5, "Administracion de empresas", 20, 0.15F);
            // Universidad antioquia = new Universidad("universidad de antioquia", "calle88");
            // antioquia.Programas.Add(programa1);
            // antioquia.Programas.Add(programa2);
            // antioquia.Programas.Add(programa3);
            // antioquia.Programas.Add(programa4);
            // antioquia.Programas.Add(programa5);
            // bool continuar = true;
            // while (continuar)
            // {
            //     Console.WriteLine("MENÚ DE UNIVERSIDAD \n1. Consultar informacion\n2. Matricular\n3. Salir");
            //     int opcion = int.Parse(Console.ReadLine());

            //     switch (opcion)
            //     {

            //         case 1:
            //             antioquia.MostrarInfo();
            //             break;
            //         case 2:
            //             Console.WriteLine("Selecciona el id del programa que deseas matricularte");
            //             foreach (var programa in antioquia.Programas)
            //             {
            //                 programa.MostrarInfo();
            //             }
            //             int programaMatricula = int.Parse(Console.ReadLine());
            //             antioquia.Matricular(estudiante, programaMatricula);
            //             break;
            //         case 3:
            //             Console.WriteLine("Saliendo del programa");
            //             continuar = false;
            //             break;

            //         default:
            //             Console.WriteLine("Opcion no validad");
            //             break;


            //     }

            // }







            //    Ejercicio 6
            //.La empresa de tecnología “COMPUTRONIC”, es una empresa líder en venta y
            // distribución de equipos tecnológicos en la ciudad de Bogotá y cuenta en su única sede
            // con un N cantidad de empleados quienes realizanN ventas durante el día. La empresa
            // requiere identificar cuántas de las ventas fueron menores o iguales a $300.000,
            // cuántas ventas fueron mayores a $
            // 300.000 y menores a $800.000 y cuántas fueron mayores o iguales a
            // $800.000 por cada empleado.
            // También se necesita conocer monto total por la venta realizada por empleado y las
            // bonificaciones a pagar según la venta realizada. Para el pago de la bonificación es
            // necesario tener en cuenta la siguiente tabla:
            // Venta Realizada
            // % Pago
            // Bonificación
            // Ventas superiores o iguales a $400.000 3%
            // Ventas entre $400.001 a $800.000 5%
            // Ventas superiores a $800.000 10%
            // Al finalizar el día, se debe calcular el valor a pagar por empleado, especificando: pago
            // básico y el valor de la bonificación recibida. Tenga en cuenta que el pago básico para
            // todos los empleados es de $500.000
            // Desarrolle una solución básica de programación que le permita a la empresa
            // COMPUTRONIC conocer toda la información que es de su interés. Los valores para
            // ingresar deben ser números positivos. 



            // Ejercicio 9


            //Ejercicio 9
            Console.WriteLine("ingresa la capacidad del camion (Litros)");
            float capacidadCamion = float.Parse(Console.ReadLine());
            float capacidad = 0;
            int numeroSaco = 1;
            bool continuar = true;
            while (continuar)
            {

               if (capacidadCamion < 3000)
               {
                    Console.WriteLine("No se pueden agregar mas sacos, ningun saco puede cumplir la capacidad minima ");
                   continuar = false;
               }
                Console.WriteLine($"ingresa la capacidad del saco #{numeroSaco} (Litros)");
               float saco = float.Parse(Console.ReadLine());
                
               if ((capacidad + saco) > capacidadCamion)
               {
                    Console.WriteLine("este saco excede el limite del camion");
                   continuar = false;
               }
               else
               {
                   capacidad += saco;
               }
                
            }
            Console.WriteLine("no puedes agregar mas sacos, despache el camion ");






        }
    }
}