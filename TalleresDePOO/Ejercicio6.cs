using System;

namespace MiProyecto.App

{
    internal class Ventas
    {
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string Autor { get; set; }

        public int AnioPublicacion { get; set; }


        public Ventas(string Titulo, string Editorial, string Autor, int AnioPublicacion)
        {
            this.Titulo = Titulo;
            this.Editorial = Editorial;
            this.Autor = Autor;
            this.AnioPublicacion = AnioPublicacion;

        }


    }
    
    internal class Empleado
    {
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string Autor { get; set; }

        public int AnioPublicacion { get; set; }


        public Empleado(string Titulo, string Editorial, string Autor,int AnioPublicacion)
        {
            this.Titulo = Titulo;
            this.Editorial = Editorial;
            this.Autor = Autor;
            this.AnioPublicacion = AnioPublicacion;

        }


    }
    



}