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
		public void ContraseñaNoVacia()
		{

			bool esValida = ValidadorUsuario.EsContrasenyaValida("");
			Assert.IsFalse(esValida);

		}
		[TestMethod]
		public void ContraseñaNoNull()
		{
			bool esValida = ValidadorUsuario.EsContrasenyaValida(null);
			Assert.IsFalse(esValida);
		}

		[TestMethod]
		public void ContraseñaMinimaLongitud()
		{
			bool esValida = ValidadorUsuario.EsContrasenyaValida("1234567");
			Assert.IsFalse(esValida);
		}

		[TestMethod]
		public void ContenerCaracteresEspeciales()
		{
			bool esValida = ValidadorUsuario.EsContrasenyaValida("1234#5678");
			Assert.IsTrue(esValida);
		}

	}
}
