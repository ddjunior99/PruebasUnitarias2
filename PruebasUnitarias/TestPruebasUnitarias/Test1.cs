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
		public void ContraseñaValida()
		{
			
			bool esValida = ValidadorUsuario.EsContrasenyaValida(contraseña);
			
			Assert.IsTrue(esValida);

		}
	}
}
