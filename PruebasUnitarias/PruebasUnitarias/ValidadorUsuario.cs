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
			long resultado = 1;
			if (numero > 0)
			{
				for (int i = 1; i <= numero; i++)
				{
					resultado *= i;
				}
			}
			return resultado;
		}
		
		public static bool EsContrasenyaValida(string contrasenya) 
		{
			if (string.IsNullOrEmpty(contrasenya) || contrasenya.Length < 8 || !contrasenya.Contains("#"))
            {
                return false;
            }
			else
			{
                return true;
            }
		}

	}
}
