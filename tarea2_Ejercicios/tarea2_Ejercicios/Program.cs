using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tarea2_Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string cedula;
            double aumento;
            double salario_bruto;
            double salario_neto;
            double deducciones;
            int tipo_empleado;
            double cantidad_horas;
            double precio_hora;
            double salario_ordinario;
            int cantidad;
            int conO = 0;
            int conT = 0;
            int conP = 0;
            double acumuladoNeto_Operario = 0;
            double acumuladoNeto_Tecnico = 0;
            double acumuladoNeto_Profesional = 0;
            Console.Write("Este programa brinda informacion sobre los aumentos de salario de empleados.\nDigite la cantidad de empleados que desea consultar: ");
            cantidad = int.Parse(Console.ReadLine());
            int[] datos = new int[cantidad];
            for (int i = 0; i < datos.Length; i++)
            {
                Console.Write("Escriba el nombre: "); nombre = Console.ReadLine();
                Console.Write("Digite el numero de cédula: "); cedula = Console.ReadLine();
                //Console.Write("Tipos de empleado:\n1-Operario\n2-Técnico\n3-Profesional\nDigite un número de acuerdo al tipo de empleado: ");
                //tipo_empleado = int.Parse(Console.ReadLine());
                Console.Write("Digite la cantidad de horas laboradas "); cantidad_horas = double.Parse(Console.ReadLine());
                Console.Write("Digite el precio por hora: "); precio_hora = double.Parse(Console.ReadLine());
                salario_ordinario = (cantidad_horas * precio_hora);
                Console.Write("Tipos de empleado:\n1-Operario\n2-Técnico\n3-Profesional\nDigite un número de acuerdo al tipo de empleado: ");
                tipo_empleado = int.Parse(Console.ReadLine());
                if (tipo_empleado == 1)
                {
                    aumento = (salario_ordinario * 0.15);
                    salario_bruto = (salario_ordinario + aumento);
                    deducciones = (salario_bruto * 9.17 / 100);
                    salario_neto = (salario_bruto - deducciones);
                    conO += 1;
                    acumuladoNeto_Operario += salario_neto;
                    Console.WriteLine("Los datos del empleado: " + nombre + " cedula " + cedula + " son los siguientes:\nSalario Ord ¢" + salario_ordinario + " el aumento es de ¢" + aumento + " las deducciones ¢" + deducciones + " el salario neto es de ¢" + salario_neto);
                    Console.Read();
                }
                else if (tipo_empleado == 2)
                {
                    aumento = (salario_ordinario * 0.10);
                    salario_bruto = (salario_ordinario + aumento);
                    deducciones = (salario_bruto * 9.17 / 100);
                    salario_neto = (salario_bruto - deducciones);
                    conT += 1;
                    acumuladoNeto_Tecnico += salario_neto;
                    Console.WriteLine("Los datos del empleado: " + nombre + " cedula " + cedula + " son los siguientes:\nSalario Ord ¢" + salario_ordinario + " el aumento es de ¢" + aumento + " las deducciones ¢" + deducciones + " el salario neto es de ¢" + salario_neto);
                    Console.Read();
                }
                else if (tipo_empleado == 3)
                {
                    aumento = (salario_ordinario * 0.05);
                    salario_bruto = (salario_ordinario + aumento);
                    deducciones = (salario_bruto * 9.17 / 100);
                    salario_neto = (salario_bruto - deducciones);
                    conP += 1;
                    acumuladoNeto_Profesional += salario_neto;
                    Console.WriteLine("Los datos del empleado: " + nombre + " cedula " + cedula + " son los siguientes:\nSalario Ord ¢" + salario_ordinario + " el aumento es de ¢" + aumento + " las deducciones ¢" + deducciones + " el salario neto es de ¢" + salario_neto);
                    Console.Read();
                } // Console.WriteLine("Acumulado de salarios netos de acuerdo al tipo: 

                Console.Read();

            }
            Console.WriteLine("Datos adicionales: \nCantidad empleados de acuerdo al tipo: \nOperario: " + conO + "\nTécnico: " + conT + "\nProfesional: " + conP);
            Console.WriteLine("Acumulado de salarios netosde acuerdo al tipo: \nOperario:¢ " + acumuladoNeto_Operario + "\nTécnico:¢ " + acumuladoNeto_Tecnico + "\nProfesional:¢ " + acumuladoNeto_Profesional);
            Console.Read();

        }
    }
}
