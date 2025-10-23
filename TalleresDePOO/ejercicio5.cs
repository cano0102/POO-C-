using System;
using System.Numerics;

namespace ConsoleApp
{
    internal class Universidad
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public float Ingresos { get; set; }
        public float ReporteNoIngresos { get; set; }
        public int Descuento { get; set; }
        public int TotalCreditos { get; set; }
        public List<ProgramaAcademico> Programas = new List<ProgramaAcademico>();

        public Universidad(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            Descuento = 0;
            Ingresos = 0;
            TotalCreditos = 0;
            ReporteNoIngresos = 0;
        }

        public void MostrarInfo()
        {
            if (Programas.Count >= 1)
            {
                foreach (var programa in Programas)
                {
                    Console.WriteLine($"Id: {programa.Id}\nNombre: {programa.Nombre}\nValor de creditos:{programa.Creditos}");
                }
            }
            else
            {
                Console.WriteLine("Actualmente no hay programas academicos");
            }

            Console.WriteLine($"Total recaudado: {TotalCreditos}\ndescuentos concedidos:{Descuento}");

        }

        public void Matricular(Estudiante estudiante, int programaMatricula)
        {
            ProgramaAcademico programa = Programas.Find(p => p.Id == programaMatricula);
            if (programa != null)
            {
                Console.WriteLine("en que deseas pagar? (t = transferencia - e = efectivo)");
                String respuesta = Console.ReadLine();
                if (respuesta.ToUpper() == "E")
                {
                    float total = (programa.Creditos * 200);
                    ReporteNoIngresos += total;
                    Ingresos += total + (total * programa.Descuento);
                    estudiante.Creditos += total + (total * programa.Descuento);
                    Descuento++;
                    TotalCreditos += programa.Creditos * 200;
                    programa.Recaudo += total + (total * programa.Descuento);
                    programa.Matriculados.Add(estudiante);
                    Console.WriteLine($"{estudiante.Nombre} Matriculado con exito al programa academico: {programa.Nombre} (se ha aplicado descuento del {programa.Descuento*100}% por el pago en efectivo)");
                }
                else
                {
                    float total = programa.Creditos * 200;
                    estudiante.Creditos += total;
                    ReporteNoIngresos += total;
                    Ingresos += total;
                    TotalCreditos += programa.Creditos;
                    programa.Matriculados.Add(estudiante);
                    programa.Recaudo += total;
                    Console.WriteLine($"{estudiante.Nombre} Matriculado con exito al programa academico: {programa.Nombre}");
                }
            }
            else
            {
                Console.WriteLine("No se ha encontrado el programa academico");
            }


        }
    }

    internal class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public float Creditos { get; set; }

        public Estudiante(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
            Creditos = 0;
        }

    }

    internal class ProgramaAcademico
    {
        public int Id { set; get; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        public float Recaudo { get; set; }
        public float Descuento { get; set; }
        public List<Estudiante> Matriculados = new List<Estudiante>();

        public ProgramaAcademico(int id, string nombre, int creditos, float descuento)
        {
            Id = id;
            Nombre = nombre;
            Creditos = creditos;
            Recaudo = 0;
            Descuento = descuento;
        }
        
        public void MostrarInfo()
        {
            Console.WriteLine($"Id: {Id} Nombre: {Nombre} cantidad de matriculados: {Matriculados.Count}");

        }
        
    }

}