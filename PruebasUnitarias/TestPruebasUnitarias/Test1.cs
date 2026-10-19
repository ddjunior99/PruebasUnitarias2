namespace TestPruebasUnitarias
{
	[TestClass]
	public sealed class Test1
	{
		[TestMethod]
		public void TestMethod1()
		{

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
