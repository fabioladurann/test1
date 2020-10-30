

using System.Linq.Expressions;
using System.Security.Permissions;

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
       public static double MayorReal(double a, double b)
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

        public static void  EjercicioError(int code)
        {
             switch (code)
             {
               
             }

        }
        //Hcaer un funcion que reciba un numero y en funcion de ese numero que imprima la siguiente serie 0,3,6,9,12...
        //Ejemplo: Funcion (10) 0,3,6,9 // Función (0) // Funcion(12) 0,3,6,9,12
        public static void PrintSerie3(int n)
        {
            int i = 0;
            while (i <= n)
            {
                System.Console.Write(i + "," );  // + es una concatenacion, no una suma porque esta con int 
                i+=3;
            }
        }

     }

 }
