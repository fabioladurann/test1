using Ejemplo2;
using System;

namespace OtroTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool sol;
            sol = Utils.IsEven(4);

            Ejercicios.Ejercicio1();

            Ejercicios.Ejercicio2(4);

            Ejercicios.Ejercicio3(6);

            int numero = 4;
            while (numero < 90)
            {
                Ejercicios.Ejercicio3(numero);
                numero++;
            }
            

        }

    }
}
