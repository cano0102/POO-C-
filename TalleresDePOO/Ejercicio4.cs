using System;

namespace MiProyecto.App

{


    internal class Libro
    {
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string Autor { get; set; }

        public int AnioPublicacion { get; set; }


        public Libro(string Titulo, string Editorial, string Autor,int AnioPublicacion)
        {
            this.Titulo = Titulo;
            this.Editorial = Editorial;
            this.Autor = Autor;
            this.AnioPublicacion = AnioPublicacion;

        }


    }

    internal class Biblioteca
    {
        public List<Libro> Libros = new List<Libro>();
        public void AgregarLibro()
        {

            Console.WriteLine("Dame el nombre del libro :");
            string nombre = Console.ReadLine();

            Console.WriteLine("Dame el editorial del libro :");
            string editorial = Console.ReadLine();


            Console.WriteLine("Dame el autor del libro :");
            string autor = Console.ReadLine();


            Console.WriteLine("Dame el anio del libro :");
            int anioPublicacion = int.Parse(Console.ReadLine());


            Libro CaracteristicasDelLibro = new Libro(nombre, editorial, autor, anioPublicacion);

            Libros.Add(CaracteristicasDelLibro);

            Console.WriteLine("Libro agragado");


             
            


        }

        public void ListarLibros()
        {
            foreach (var LibroListado in Libros)
            {
                Console.WriteLine($"NOMBRE {LibroListado.Titulo} Editorial:{LibroListado.Editorial} Autor: {LibroListado.Autor} Anio {LibroListado.AnioPublicacion} ");
            }
        }
        
        
    }
}