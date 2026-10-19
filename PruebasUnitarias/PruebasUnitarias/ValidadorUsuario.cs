using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasUnitarias
{
	public class ValidadorUsuario
	{
		public static long CalcularFactorial(int numero)
		{
			if (numero < 0)
				return -1;
			if (numero == 0) 
				return 1;
			if (numero > 0)
			{
				long resultado = 1;
				for (int i = 1; i <= numero; i++)
				{
					resultado *= i;
				}
				return resultado;

			}
		}
		public static bool EsContrasenyaValida() { }
	}
}
