using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EjercicioPractico2.Clases;
namespace EjercicioPractico2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Factura factura = new Factura();
            Producto producto = new Producto();
            ProductoPorFactura productoPorFactura = new ProductoPorFactura();


            //Cliente
            Console.WriteLine("Ingrese su identificasion");
            cliente.Identificacion = Console.ReadLine();
            Console.WriteLine("Ingrese su Nombre");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingese su Direccion");
            cliente.Direccion = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono");
            cliente.Telefono = int.Parse(Console.ReadLine());

            //Producto
            Console.WriteLine("Ingrese su Codigo");
            producto.Codigo = Console.ReadLine();
            Console.WriteLine("Ingrese su Pedido");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese precio de producto");
            producto.PrecioVenta = float.Parse(Console.ReadLine());
            Console.WriteLine("Cuantos va a querer?");
            productoPorFactura.Cantidad = int.Parse(Console.ReadLine());

            

            //Factura
            Console.WriteLine(" Ingrese Numero");
            factura.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingese Fecha");
            factura.Fecha = DateTime.Parse( Console.ReadLine());


            Console.ReadKey();    
        }
        
    }
}
