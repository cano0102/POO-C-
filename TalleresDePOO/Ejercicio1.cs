using System;

namespace MiProyecto.App

{
    internal static class Prestamo
    {
        public static void MostrarPrestamo()
        {
            Console.WriteLine("Ingrese el monto del prestamo");
            float monto = float.Parse(Console.ReadLine());

            float interesAnual = monto * 0.05f;

            float interesTrimestre = interesAnual / 4;
            float interesMensual = interesAnual / 12;
            float totalPagar = monto + (interesAnual * 5);
            Console.WriteLine("El dinero pagado en intereses en un año es: " + interesAnual);
            Console.WriteLine("El dinero pagado en intereses en el tercer trimestre del año es: " + interesTrimestre);
            Console.WriteLine("El dinero pagado en intereses en el primer mes es: " + interesMensual);
            Console.WriteLine("El total a pagar del prestamo solicitado incluyendo intereses es: " + totalPagar);
            Console.ReadKey();
        }
    }
}