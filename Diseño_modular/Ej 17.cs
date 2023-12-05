using System;

namespace MyNamespace
{
    class MyClass
    {
        static void Main()
        {
            const string DegreeInput = "Introduce los grados en Celcius para ver el equivalente en Fahrenheit";

            int degreesC;

            Console.WriteLine(DegreeInput);
            degreesC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{degreesC} grados Celcius equivalen a {FahrenheitCalculator(degreesC)} grados Fahrenheit");
        }

        public static float FahrenheitCalculator(int degreesC)
        {
            const int Mult = 9, Div = 5, Sum = 32;
            return degreesC * Mult / Div + Sum;
        }
    }
}