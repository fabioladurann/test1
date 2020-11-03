using Ejemplo2;
using System;

namespace OtroTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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

            Ejercicios.EjercicioSerie1();

            Ejercicios.EjercicioSerie2();

            Ejercicios.EjercicioSerie4();
            Ejercicios.EjercicioSerie5();
            */

            int result = EjerciciosExamen.HacerSuma(1, 4);
            EjerciciosExamen.MayorEntero(4, 5, 8);
            EjerciciosExamen.MayorReal(2, 4);
            EjerciciosExamen.BackEnteros(3, 8);
            EjerciciosExamen.PrintSerie3(2);
            EjerciciosExamen.PrintSerie4(4);
            EjerciciosExamen.PrintSerie5(3);
            EjerciciosExamen.Mayor7(1, 5, 8, 4, 7, 6);
            EjerciciosExamen.PrintSerie7(8);
            EjerciciosExamen.PrintSerie8(9);
            EjerciciosExamen.PrintSerie9(5);
            EjerciciosExamen.PrintSerie10(7);
        }  
        

       
    
    }
}
