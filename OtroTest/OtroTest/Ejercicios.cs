using Ejemplo2;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace OtroTest
{

	public class Ejercicios
	{
		public static void Ejercicio1()
		{
			int contador = 0;
			while (contador < 100)
			{
				System.Console.WriteLine(contador);
				contador = contador + 1;
			}


		}
		//Ejercicio: Haz una función que imprima por pantalla todos los números pares desde el 0 hasta n

		public static void Ejercicio2(int n)
		{
			int i = 0;
			while (i < n)
			{
				if (Utils.IsEven(i))
					System.Console.WriteLine(i); //Para poder esto "if" tiene que ser par, ejercicio que hemos realizado antes
				i++;
			}
		}

        internal static void EjercicioSerie5()
        {
            throw new NotImplementedException();
        }

        public static void Ejercicio3(int numero)
        {
			bool esprimo = Utils.IsPrime(numero);
			if (esprimo)

			System.Console.WriteLine("El numero" + numero + "es primo");
			else
				System.Console.WriteLine("El numero" + numero + "NO primo");
        }

		//Vamos hacer una funnción que imprima lo siguiente:
		public static void EjercicioSerie1()
        {
			int i = 0;
			while (i <= 100)
            {
				System.Console.WriteLine(i);
				i++;
            }

        }
		public static void EjercicioSerie2()
        {
			int i = 0;
			while (i <= 100)
            {
				System.Console.WriteLine(i * 2);

				i++;
            }

        }
		public static void EjercicioSerie3()
        {
			int i = 0;
			while (i <=100)
            {
				System.Console.WriteLine(i * 3 +1 );


				i++;
            }	
		
        }
		public static void EjercicioSerie4()
        {
			int i = 0;
			while (i <= 100)
            {
				System.Console.WriteLine(i * i);

				i++;
            }
        }
		

        }
		//hacer una función que imprima la función fibonacci
		public static void EjercicioSerie5() 
        {
			int a = 1;
			int aa = 0;
			int i = 100;
		System.Console.WriteLine(aa);
		System.Console.WriteLine(a);
			while (i < 100)
            {
				System.Console.WriteLine(a + aa);

				int aux = aa;
				aa = a;

				a = aux + aa;

				i++;
            }

        }
	} 

}