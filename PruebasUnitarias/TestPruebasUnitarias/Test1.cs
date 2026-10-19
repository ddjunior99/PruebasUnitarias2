using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestPruebasUnitarias;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestPruebasUnitarias
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void MenorCero()
        {
			bool resultado = ValidadorUsuario.CalcularFactorial(-1);
			Assert.AreEqual(-1, resultado);
        }
		[TestMethod]
		public void IgualACero()
        {
            bool resultado = ValidadorUsuario.CalcularFactorial(0);
            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void RestoNumsPositivos()
        {
            bool resultado = ValidadorUsuario.CalcularFactorial(5);
            Assert.AreEqual(120, resultado);
        }
        [TestMethod]
		public void ContraseñaValida()
		{
			
			bool esValida = ValidadorUsuario.EsContrasenyaValida(contraseña);
			
			Assert.IsTrue(esValida);

		}
	}
}
