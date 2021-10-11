using System;

namespace RobertoCobeña3A9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese su número:");
            num = int.Parse(Console.ReadLine());
            Console.Write("Tabla del:" + num);
            Console.Write("\n");
                for (int i = 1; i <= 15; i++)
                {
                    Console.WriteLine(num + "x" + i + "=" + num * i);
                }
        }
    }
}
