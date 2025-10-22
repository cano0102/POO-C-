using System;
namespace MiProyecto.App
{
    internal static class Salario
    {
        public static void MostrarSalario()
        {
            Console.WriteLine("Por favor ingrese su salario");
            float salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Por fovor ingrese el ahorro mensual programado");
            float ahorro = float.Parse(Console.ReadLine());
            ahorro = ahorro / 100;



            const float descuentoSalud = 0.125f;
            float resultadoSalud = salario * descuentoSalud;

            const float descuentoPensiones = 0.16F;
            float resultadoPenciones = salario * descuentoPensiones;
            float salarioPrestaciones = salario - (descuentoSalud + descuentoPensiones);

            float descuentoAhorro = salarioPrestaciones * ahorro;
            float totalDeTodo = salarioPrestaciones - descuentoAhorro;


            Console.WriteLine($"EL SALARIO ES {salario} el ahorro es el {descuentoAhorro} , el descuento de la salud es {resultadoSalud} , el desceunto de las pensiones es {resultadoPenciones} ,el descuento de las pension y la salud es {salarioPrestaciones} , descuento con el  ahorro es {totalDeTodo}");

        }

    }
}