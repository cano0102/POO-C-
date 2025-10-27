using System;
// SE DEBE CORREGIR LA FUNCION MAIN DE AHI
class CargaCamiones
{
    static void Main()
    {
        const int TOTAL_CAMIONES = 20;

        for (int i = 1; i <= TOTAL_CAMIONES; i++)
        {
            Console.WriteLine($"\nCamión #{i}");
            Console.Write("Ingrese capacidad del camión (litros): ");
            int capacidad = int.Parse(Console.ReadLine());

            int cargado = 0;
            while (true)
            {
                Console.Write("Ingrese cantidad de litros del siguiente tanque: ");
                int tanque = int.Parse(Console.ReadLine());

                if (cargado + tanque > capacidad)
                {
                    Console.WriteLine($"⚠️ No se puede cargar el tanque ({tanque} L).");
                    Console.WriteLine($"Camión #{i} despachado con {cargado} litros.\n");
                    break; // Se despacha el camión
                }
                else
                {
                    cargado += tanque;
                    Console.WriteLine($"✅ Tanque cargado. Total actual: {cargado} litros.");
                }
            }
        }

        Console.WriteLine("\n✅ Se han despachado los 20 camiones del día.");
    }
}
