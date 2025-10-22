using System;
using System.Dynamic;
using System.Net;
using System.Security.AccessControl;

namespace MiProyecto.App
{
    internal static class Objetos
    {
        public static void CrearPersona()
        {
            // Example usage: create a Persona and print whether Campo is even or odd
            Console.WriteLine("Ingresa tu nombre");
            string name = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu Genero (F || M)");
            string genero = Console.ReadLine();
            if (genero.ToUpper() == "F")
            {
                genero = "Femenino";
            }
            else if (genero.ToUpper() == "M")
            {
                genero = "Masculino";
            }
            else
            {
                genero = "indefinido";
            }
            Persona persona = new Persona { Nombre = name, Edad = age, Genero = genero };
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("que deseas hacer? \n 0. salir \n 1. mostrar informacion \n 2. editar informacion \n 3. calcular edad en dias ");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        continuar = false;
                        Console.WriteLine("Haz salido del programa");
                        break;
                    case 1:
                        persona.MostrarInformacion();
                        break;
                    case 2:
                        Console.WriteLine("Que deseas editar? \n 1. Nombre \n 2. Edad \n 3. Genero");
                        int opcion2 = int.Parse(Console.ReadLine());
                        switch (opcion2)
                        {
                            case 1:
                                Console.WriteLine($"Ingresa el nombre nuevo (nombre antiguo: {persona.Nombre}) ");
                                persona.Nombre = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine($"Ingresa la edad nueva (edad antigua: {persona.Edad}) ");
                                persona.Edad = int.Parse(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine($"Ingresa el Genero nuevo (Genero antiguo: {persona.Genero}) ");
                                string genero2 = Console.ReadLine();
                                persona.EditarGenero(genero2);
                                break;
                            default:
                                Console.WriteLine("Ingresa una opcion valida");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Edad: {persona.Edad}");
                        persona.CalcularDias();
                        break;
                    default:
                        Console.WriteLine("Ingresa una opcion valida");
                        persona.CalcularDias();
                        break;
                }
            }
        }

        public class Persona
        {
            //crearé una clase llamada "Persona" con las propiedades "Nombre", "Edad" y "Género (el
            //usuario deberá seleccionar
            //F o M) telefono". También crearé un constructor para la clase "Persona" y métodos: para
            //editar la información del usuario, agregar un nuevo usuario, imprimir los detalles de la
            //persona y otro para calcular la edad en días. El programa solicitará al usuario que ingrese los
            //detalles de la persona y luego le permitirá elegir entre dos opciones: imprimir los detalles de
            //la persona o calcular la edad en días.
            //solicita al usuario que ingrese los detalles de la persona (nombre, edad y género) y luego
            //crea un objeto "Persona" con esos detalles. Luego, le presenta al usuario un menú de
            //opciones que le permite imprimir los detalles de la persona, calcular la edad en días o salir
            //del programa. Si el usuario selecciona la opción de imprimir detalles de la persona, el
            //programa llama al método "ImprimirDetalles" de la clase "Persona", que imprime los
            //detalles de la persona en la consola. Si el usuario selecciona la opción de calcular edad en
            //días, el programa llama al método "CalcularEdadEnDias" de la clase "Persona", que calcula la
            //edad en días y la imprime en la consola
            
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Genero { get; set; }

            public void EditarGenero(string genero)
            {
                if (genero.ToUpper() == "F")
                {
                    genero = "Femenino";
                }
                else if (genero.ToUpper() == "M")
                {
                    genero = "Masculino";
                }
                else
                {
                    genero = "indefinido";
                }
                Genero = genero;

            }

            public void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre} \n edad: {Edad} \n genero: {Genero}");
            }

            public void CalcularDias()
            {
                Console.WriteLine($"edad en dias es de: {Edad * 365}");
            }

        }
    }
}
