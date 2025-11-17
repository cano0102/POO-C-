using System;

namespace ConsoleApp
{
    internal class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }


        public Producto(int Id, string Nombre, decimal Precio)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Precio = Precio;

        }

    }

    internal class ProductoCRUD
    {
        public List<Producto> productos = new List<Producto>();

        public int SiguienteId = 1;
        public void crearProducto()
        {
            Console.WriteLine("Ingresa el nombre del producto");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el Precio del producto");
            decimal precio = decimal.Parse(Console.ReadLine());

            Producto nuevoProducto = new Producto(SiguienteId++, nombre, precio);


            productos.Add(nuevoProducto);

        }

        public void LeerProducto()
        {
            foreach (var producto in productos)
            {
                Console.WriteLine($"ID {producto.Id} Precio: {producto.Nombre} PRECIO :{producto.Precio} ");
            }
        }
        public void ActualizarProducto()
        {
            Console.WriteLine("ingresa el id del producto a actualizar");
            int id = int.Parse(Console.ReadLine());
            Producto producto = productos.Find(p => p.Id == id);

            if (producto != null)
            {
                Console.WriteLine("Ingresa el nuevo nombre");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingresa el precio");
                decimal precio = decimal.Parse(Console.ReadLine());



                producto.Nombre = nombre;

                producto.Precio = precio;


                Console.Write("MUY BIEN");

                
            }
            else
            {
                Console.WriteLine("Producto no encontrado");
            }
        }

    }
        
}