using Ejemplo2;

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
	}

}