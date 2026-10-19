using System;
using System.Collections.Generic;
using System.Text;

namespace PruebasUnitarias
{
	public class ValidadorUsuario
	{
		public static long CalcularFactorial(int numero) { }
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
