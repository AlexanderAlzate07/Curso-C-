using System;
using MySecondProgram;

namespace MyFirtsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var hello = "hello world from C#";
            float temperature = 20.0f;
            Console.WriteLine($"{hello}");
            Console.WriteLine("llamado a la función de conversión de temperatura:");
            Console.WriteLine($"{temperature} grados Fahrenheit son {FahrenheitToCelsius(temperature)} grados celsius");
            //se agrega comentario en el Program.cs
            MyLibrary.PrimerMetodo();
            MyLibrary.SegundoMetodo();
            
        }


        static float FahrenheitToCelsius(float temperaureFahrenheit)
        {
            var temperaureCelsius = (temperaureFahrenheit - 32) / 1.8f;
            return temperaureCelsius;
        }
    }
}
