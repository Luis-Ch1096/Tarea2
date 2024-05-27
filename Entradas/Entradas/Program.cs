using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entradas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Este ejercicio me quedo incompleto profe, no pude hacer que cumpla todo lo solicitado, le dedique mucho tiempo y nada,
            //estoy cerrado de mente ya de tanto intentar =(
            string cedula;
            string nombre;
            int localidad;
            int cantidad_entradas = 0;
            int opcion = 0;
            int precio;
            int total;
            int cargos;
            string nombre_localidad;

            Console.WriteLine("Bienvenido, gracias por su interes en comprar entradas para el partido CR - MX");
            Console.WriteLine("Eliga una opcion:\n1- Comprar entradas.\n2- Salir. ");
            opcion = int.Parse(Console.ReadLine());
            while (opcion != 2)
            {   Console.Write("Por favor digite el número de entradas que desea comprar: ");
                cantidad_entradas = int.Parse(Console.ReadLine());
                if (cantidad_entradas > 4)
                {
                    Console.WriteLine("**ERROR**No se permite la compra mayor a 4 entradas por usuario.");
                    Console.WriteLine("Eliga una opcion:\n1- Comprar entradas.\n2- Salir. ");
                    opcion = int.Parse(Console.ReadLine());
                }
                Console.Write("Por favor digite un número de acuerdo a la localidad:\n 1- Sol Norte/Sur ¢10.500\n 2- Sombra Este/Oeste ¢20500\n 3- Preferencial ¢25500 ");
                localidad = int.Parse(Console.ReadLine());
               
                if (cantidad_entradas <= 4 & localidad == 1)
                {
                    Console.Write("Digite su nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Digite su número de cédula: ");
                    cedula = Console.ReadLine();
                    precio = (10500 * cantidad_entradas);
                    cargos = (cantidad_entradas * 1000);
                    total = (precio + cargos);
                    nombre_localidad = "Sol Norte/Sur";
                    Console.WriteLine("Transaccion exitosa.\nDetalles: Compra a nombre de: " + nombre + "\nCédula: " + cedula + " Localidad:" + nombre_localidad + " Subtotal:" + precio + " Total:" + total);
                    Console.WriteLine("Eliga una opcion:\n1- Comprar entradas.\n2- Salir. ");
                    opcion = int.Parse(Console.ReadLine());
                }
                else if (cantidad_entradas <= 4 & localidad == 2)
                {
                    Console.Write("Digite su nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Digite su número de cédula: ");
                    cedula = Console.ReadLine();
                    precio = (20500 * cantidad_entradas);
                    cargos = (cantidad_entradas * 1000);
                    total = (precio + cargos);
                    nombre_localidad = "Sombra Este/Oeste";
                    Console.WriteLine("Transaccion exitosa.\n Detalles: Compra a nombre de: " + nombre + "\nCédula: " + cedula + " Localidad: " + nombre_localidad + " Subtotal: " + precio + " Total: " + total);
                    Console.WriteLine("Eliga una opcion:\n1- Comprar entradas.\n2- Salir. ");
                    opcion = int.Parse(Console.ReadLine());

                }
                else if (cantidad_entradas <= 4 & localidad == 3)
                {
                    Console.Write("Digite su nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Digite su número de cédula: ");
                    cedula = Console.ReadLine();
                    precio = (25500 * cantidad_entradas);
                    cargos = (cantidad_entradas * 1000);
                    total = (precio + cargos);
                    nombre_localidad = "Preferencial";
                    Console.WriteLine("Transaccion exitosa.\n Detalles: Compra a nombre de: " + nombre + "\nCédula: " + cedula + " Localidad: " + nombre_localidad + " Subtotal: " + precio + " Total: " + total);
                    Console.WriteLine("Eliga una opcion:\n1- Comprar entradas.\n2- Salir. ");
                    opcion = int.Parse(Console.ReadLine());

                }
                else{

                    Console.WriteLine("**ERROR**No se permite la compra mayor a 4 entradas por usuario.");
                    Console.WriteLine("Eliga una opcion:\n1- Comprar entradas.\n2- Salir. ");
                    opcion = int.Parse(Console.ReadLine());
                    Console.Read();
                }


            }
             Console.Read();
            
        }
        
    }
}
