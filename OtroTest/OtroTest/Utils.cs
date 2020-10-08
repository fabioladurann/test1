using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ejemplo2
{
    class Utils
    {
        public static int GetMinValue(int a, int b)
        {
            if (a > b)
            {
                return a;

            }
            else
            {
                return b;
            }

        }

        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)
                return true;
            else
                return false;
        }

        //Funcion que nos devuelve si un numero es primo o no

        public static bool IsPrime(int number)
        {
            int i = 2;
            while ( i < number)
            {
                if ((number % i) == 0)
                    return false;
                i++;
            }
            return true;
        }

    }
}

