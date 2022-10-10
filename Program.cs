using System;

namespace C_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string nombre;
            Console.WriteLine("Ingrese su nombre completo");
            nombre=Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;  
            Console.BackgroundColor = ConsoleColor.Red; 
            Console.WriteLine("///Bienvenido "+nombre+"//");
            Console.ResetColor();

        }
    }
}
