using System;

namespace MiProyecto.App


            //    Ejercicio 6
            //.La empresa de tecnología “COMPUTRONIC”, es una empresa líder en venta y
            // distribución de equipos tecnológicos en la ciudad de Bogotá y cuenta en su única sede
            // con un N cantidad de empleados quienes realizanN ventas durante el día. La empresa
            // requiere identificar cuántas de las ventas fueron menores o iguales a $300.000,
            // cuántas ventas fueron mayores a $
            // 300.000 y menores a $800.000 y cuántas fueron mayores o iguales a
            // $800.000 por cada empleado.
            // También se necesita conocer monto total por la venta realizada por empleado y las
            // bonificaciones a pagar según la venta realizada. Para el pago de la bonificación es
            // necesario tener en cuenta la siguiente tabla:
            // Venta Realizada
            // % Pago
            // Bonificación
            // Ventas superiores o iguales a $400.000 3%
            // Ventas entre $400.001 a $800.000 5%
            // Ventas superiores a $800.000 10%
            // Al finalizar el día, se debe calcular el valor a pagar por empleado, especificando: pago
            // básico y el valor de la bonificación recibida. Tenga en cuenta que el pago básico para
            // todos los empleados es de $500.000
            // Desarrolle una solución básica de programación que le permita a la empresa
            // COMPUTRONIC conocer toda la info

{
    internal class Empleado

    {
        public string Nombre { get; set; }
        public float Salario { get; set; }
        public string Equipo { get; set; }

        public float PrecioDeEquipo { get; set; }


        public Empleado(string Nombre, string Equipo, float PrecioDeEquipo)
        {
            this.Nombre = Nombre;
            Salario = 500000;
            this.Equipo = Equipo;
            this.PrecioDeEquipo = PrecioDeEquipo;

        }


    }
    
    internal class Ventas
    {
      public List<Empleado> ventas = new List<Empleado>();
        public void AgregarVenta()
        {

        }
        public void SacarPorcentajeDePrecioVenta()
        {

        }
        public void ReporteDeVentas()
        {

        }
        
        public void SueldoDelEmpleadoYReporte()
        {
            
        }
      
    }
    



}