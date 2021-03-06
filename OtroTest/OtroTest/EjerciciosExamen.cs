﻿
using System;
using System.Reflection.Metadata;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace OtroTest
{
    class EjerciciosExamen
    { //Hacer una funcion que reciba dos numero entero(int) y devuelva una suma de los dos 
        public static int HacerSuma(int a, int b) //recibe dos enteros 
        {
            int result = a + b;
            return result;
        }
        //Hacer una funcion que reciba dos reales y que devuelva la resta de los reales 
        public static double HacerResta(double a, double b)
        {
            double result = a - b;
            return result;
        }
        //Hacer dos funciones que reciban dos reales, la primera la mayor de los reales y la segunda la menor de los reales 
        public static int MayorReal(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static double MenorReal(double a, double b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        //Hacer una función que se le pasan tres enteros y que devuelve el mayor de los tres
        public static int MayorEntero(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b > c)
                    return b;
                else
                    return c;
            }
        }
        //Hacer una funcion que reciba dos enteros y devuelva -1 si el primero es menor que el segundo
        // 1 si el segundo si es menor que el primero
        // 0 si los dos son iguales 
        public static int BackEnteros(int a, int b)
        {
            if (a > b)
                return -1;
            else if (a > b)
                return 1;
            return 0;

        }
        //Hacer una función que recibo un "codigo de error y muestre por pantalla lo siguiente 
        //"Error grave" si el error es 0
        //" Error moderado" si el error es 1
        // "Error leve" si el error es 2 
        // "Error desconocido" en cualquier otro caso 

        public static void EjercicioError(int code)
        {
            switch (code)
            {
                case 0:
                    System.Console.WriteLine("Error grave");
                    break;
                case 1:
                    System.Console.WriteLine("Error grave");
                    break;
                default:
                    System.Console.WriteLine("");
                    break;
            }

        }
        //Hcaer un funcion que reciba un numero y en funcion de ese numero que imprima la siguiente serie 0,3,6,9,12...
        //Ejemplo: Funcion (10) 0,3,6,9 // Función (0) // Funcion(12) 0,3,6,9,12
        public static void PrintSerie3(int n)
        {
            int i = 0;
            while (i <= n)
            {
                System.Console.Write(i + ",");  // + es una concatenacion, no una suma porque esta con int 
                i += 3;
            }
        }
        //Hacer una funcion que reciba un numero entero e imprima todos los numeros desde el 0, hasta ese numero
        public static void PrintSerie4(int n)
        {
            for (int i = 0; i <= n; i++)
                System.Console.Write(i + ",");

        }
        //Hacer lo mismo de arriba pero que la coma no apatezca
        public static void PrintSerie5(int n)
        {
            for (int i = 0; i <= n; i++)
                System.Console.Write(i);
            if (n > 0)
                System.Console.Write(",");
        }
        //Hacer una funcion que devuleva el mayor de 6 enteros. Y que esa funcion ocupe una linea
        public static int Mayor6(int a,int b, int c, int d, int e, int f)
        {
            return 0;
            //return MayorReal(MayorEntero(a, b, c),MayorEntero )
        }
        //En tres lineas seria asi
        public static int Mayor7 (int a, int b, int c, int d, int e, int f)
        {
            int mayor1 = MayorEntero(a, b, c);
            int mayor2 = MayorEntero(d, e, f);
            return MayorReal (mayor1, mayor2);
        }
        //Hacer una funcion que se le pase un entero e imprima tantos asteriscos (*) como ese entero que se le pasa
        public static void PrintSerie7(int n)
        {
            for (int i = 0; i < n; i++)
            {
                System.Console.Write("*");
            }
        }
        //Hacer lo mismo de arriba pero que imprima "*+"
        public static void PrintSerie8(int n)
        {
            for (int i = 0; i <= 0; i++)
            {
                if ((i % 2) == 0)
                    System.Console.Write("*");
                else
                    System.Console.Write(",");
            }
               
        }
        //Hacer lo mismo que arriba pero tiene que imprimir(*+-/*+-...)
        //El patron es de 4
        public static void PrintSerie9(int n)
        {
            for (int i = 0; i <= 0; i++)
            {
                int resto = i % 4;
                switch (resto)
                {
                    case 0:
                        System.Console.WriteLine("*");
                            break;
                    case 1:
                        System.Console.WriteLine("+");
                            break;
                    case 2:
                        System.Console.WriteLine("-");
                             break;
                    case 3:
                        System.Console.WriteLine("/");
                             break;
                }
            }                        
        }
        // Hacer una funcion que reciba un numero y en funcion de ese numero imprima lo siguiente:
        // figura (3) : *** figura (4) *****
        public static void PrintSerie10(int n) //en castellano seria f de fila y c de columna, por eso cambiamos la i y j por lo que hemos comentado anteriormente
        {
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                    System.Console.Write("*");

                    System.Console.WriteLine();
            }
        }
        // Hacer lo mismo que arriba pero que imprima en una "*** +++" y en la otra "*** +++"
        public static void PrintSerie11(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if ((i % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
        }
        // Hacer lo mismo pero que figura (3) *+* (3filas) y figur 4 *+*+ (4filas)
        public static void PrintSerie12(int n)
        {
            for (int f= 0; f < n; f++)
            {
                 for (int c = 0; c < n; c++)
                 {
                      int flag = c + f;
                      if ((flag % 2 == 0))
                           System.Console.Write("*");
                      else
                           System.Console.Write("+");
                 }
                 System.Console.WriteLine(); // Salto de linea 

            }
        }  
        public static void PrintSeri13(int n)
        {
            for (int f = 0; f < 0; f++)
            {
                int nespacios = n - f - 1;
                int nasteriscos = f + 1;
                for ( int c = 0; c < n; c++)
                {
                  
        
                }
            }
        }
        public static void PrintSeire14 (int n)
        {
            for ( int f = 0; f < n; f++)
            {
                int nespacios1 = n - f - 1;
                int nespacios2 = f * 2;                                  
            }
        }
        //Hacer una funciíon que devuelva el sumatorio de un numero
        public static int Sumatorio(int n)
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
                result += i;
            return result;

        }
        //Haz una funcion que devuelva 2 elevado a un numero
        // Esta funcion devuelve un double por lo tanto, el de abajo es la opcion mas correcta
        public static int Elevado(int n)
        {
            int result = 1; //Aqui por donde quieres empezar la funcion 1*= 2
            for (int i = 0; i <= n; i++)
                result *= 2; // Aqui hacer lo que realmente quieres poner, es decir, el elevado a 2
            return result; 
        }
        public static double Elevado2(int n)
        {
            bool invertv_value = n < 0;
            if (invertv_value)
                n = -n;
            for (int i = 0; i < n; i++)
                result *= 2.0;
            if (invertv_value)
                result = 1.0 /result;
            return result;



        }
     }


        
 }
