using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Angel Calderon Ramirez

namespace InfCuentaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {   // variables a utilizar
            string nombre = string.Empty; 
            string tipoCuenta = string.Empty;
            String cuenta = "100245 ";
            String literalCuenta = string.Empty;
            Double saldoActual = 25500.75;

            // proceso Bienvenida
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bienvenido a ATM ");
            Console.Write("\n");


            // proceso Nombre
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ingrese su nombre por favor: ");
            nombre = Console.ReadLine();
            Console.Write("\n");

            // ingrese su numero de cuenta
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ingrese su numero de cuenta por favor: ");
            cuenta = Console.ReadLine();
            Console.WriteLine("\n");
            
            if (cuenta != "100245")
            {
                while (cuenta != "100245")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número de cuenta inválido. Por favor, ingrese un número válido.");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Ingrese su numero de cuenta por favor: ");
                    cuenta = Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Cuenta Validad");
            }
               
            // tipo de cuenta
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ingrese el tipo de cuenta (C para cuenta corriente, A para cuenta de ahorros): ");
            tipoCuenta = Console.ReadLine().ToUpper();

            if (tipoCuenta == "A")
            {
                 literalCuenta = "Cuenta de Ahorros";
            } else if (tipoCuenta == "C" )
            {
                 literalCuenta = "Cuenta Corriente";
            }
       

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string saldo = string.Format(" RD${0:#,##0.00}", saldoActual);
            // proceso de salida de datos
           
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====================================");
            Console.WriteLine("              INFORMACION            ");
            Console.WriteLine("====================================");
            Console.Write("\n");
            Console.WriteLine($"Cliente: {nombre}");
            Console.WriteLine($"Numero de Cuenta: {cuenta}");
            Console.WriteLine($"Cuenta de : {literalCuenta}");
            Console.WriteLine($"Saldo:{saldo}");
            Console.Write("\n");
            Console.WriteLine("====================================");


            Console.ReadLine();
        }
    }
}
