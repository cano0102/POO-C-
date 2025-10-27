using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal static class Arrays
    {
        // Listas estáticas para guardar productos y precios
        private static readonly List<string> Productos = new();
        private static readonly List<float> Precios = new();

        // Método para agregar un producto con su precio
        public static void AgregarProducto(string producto, float precio)
        {
            Productos.Add(producto);
            Precios.Add(precio);
        }

        // Método que muestra ejemplos con arrays y listas
        public static void Array()
        {
            // Ejemplo con lista de enteros
            var numeros = new List<int> { 10, 20, 30 };

            Console.WriteLine("Lista de números:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            // Eliminar el primer número
            numeros.RemoveAt(0);

            Console.WriteLine("\nLista después de eliminar el primer elemento:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            // Ejemplo con productos
            AgregarProducto("Manzana", 2.5f);
            AgregarProducto("Banano", 1.2f);
            AgregarProducto("Leche", 3.8f);

            Console.WriteLine("\nLista de productos y precios:");
            for (int i = 0; i < Productos.Count; i++)
            {
                Console.WriteLine($"{Productos[i]} - ${Precios[i]}");
            }
        }
    }


}
