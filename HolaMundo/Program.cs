using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;
            int num3, num4, num5;

            double d1 = 3.2;
            double d2 = 1.337;
            num3 = 25;

            float f1 = 3.5f;

            string MiNombre = "Janet";
            string mensaje = "Mi nombre es " + MiNombre;

            string MensMay = mensaje.ToUpper();

            Console.WriteLine(MensMay);
            Console.Read();

        }
    }
}
