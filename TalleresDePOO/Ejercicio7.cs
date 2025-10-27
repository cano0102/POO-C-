using System;
using System.Collections.Generic;
// SE DEBE CORREGIR LA FUNCION MAIN DE AHI
class ProgramaAccidentes
{
    class Conductor
    {
        public int AnioNacimiento { get; set; }
        public int Sexo { get; set; } // 1: Femenino, 2: Masculino
        public int Registro { get; set; } // 1: Bogotá, 2: Otras ciudades
    }

    static void Main()
    {
        List<Conductor> conductores = new List<Conductor>();
        int actual = DateTime.Now.Year;

        Console.Write("Ingrese la cantidad de conductores: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nConductor #{i + 1}");

            Console.Write("Año de nacimiento: ");
            int anio = int.Parse(Console.ReadLine());

            Console.Write("Sexo (1: Femenino, 2: Masculino): ");
            int sexo = int.Parse(Console.ReadLine());

            Console.Write("Registro del carro (1: Bogotá, 2: Otras ciudades): ");
            int registro = int.Parse(Console.ReadLine());

            conductores.Add(new Conductor { AnioNacimiento = anio, Sexo = sexo, Registro = registro });
        }

        // Cálculos
        int total = conductores.Count;
        int menores30 = 0;
        int masculinos = 0;
        int femeninos = 0;
        int mascEntre12y30 = 0;
        int fueraBogota = 0;

        foreach (var c in conductores)
        {
            int edad = actual - c.AnioNacimiento;

            if (edad < 30) menores30++;
            if (c.Sexo == 1) femeninos++;
            else if (c.Sexo == 2)
            {
                masculinos++;
                if (edad >= 12 && edad <= 30)
                    mascEntre12y30++;
            }
            if (c.Registro == 2) fueraBogota++;
        }

        // Resultados
        Console.WriteLine("\n--- RESULTADOS ---");
        Console.WriteLine($"Porcentaje de conductores menores de 30 años: {(menores30 * 100.0 / total):F2}%");
        Console.WriteLine($"Porcentaje de conductores femeninos: {(femeninos * 100.0 / total):F2}%");
        Console.WriteLine($"Porcentaje de conductores masculinos: {(masculinos * 100.0 / total):F2}%");
        Console.WriteLine($"Porcentaje de conductores masculinos entre 12 y 30 años: {(mascEntre12y30 * 100.0 / total):F2}%");
        Console.WriteLine($"Porcentaje de conductores con carros registrados fuera de Bogotá: {(fueraBogota * 100.0 / total):F2}%");
    }
}
