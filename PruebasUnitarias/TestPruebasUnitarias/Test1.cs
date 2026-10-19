using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestPruebasUnitarias;
using System;
using System.Collections.Generic;
using System.Text;
using PruebasUnitarias;

namespace TestPruebasUnitarias
{
    public sealed class Test1
    {
        [TestMethod]
        public void MenorCero()
        {
			long resultado = ValidadorUsuario.CalcularFactorial(-1);
			Assert.AreEqual(-1, resultado);
        }
		[TestMethod]
		public void IgualACero()
        {
            long resultado = ValidadorUsuario.CalcularFactorial(0);
            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void RestoNumsPositivos()
        {
            long resultado = ValidadorUsuario.CalcularFactorial(5);
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
