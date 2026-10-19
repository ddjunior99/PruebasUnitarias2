using PruebasUnitariasApp;

namespace TestPruebasUnitariasApp
{
    [TestClass]
    public sealed class ValidadorUsuarioTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool result = ValidadorUsuario.EsMayorDeEdad(25);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MayorEdadTest()
        {
            bool result = ValidadorUsuario.EsMayorDeEdad(10);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Es_Edad_0()
        {
            var ex = Assert.ThrowsExactly<ArgumentException>(
            () => ValidadorUsuario.EsMayorDeEdad(0)
            );
            Assert.AreEqual(ValidadorUsuario.EDAD_0_MESSAGE, ex.Message);
        }
        [TestMethod]
        public void Es_Edad_Negativa()
        {
            var ex = Assert.ThrowsExactly<ArgumentException>(
            () => ValidadorUsuario.EsMayorDeEdad(-5)
            );
            Assert.AreEqual(ValidadorUsuario.EDAD_NEGATIVE_MESSAGE, ex.Message);
        }

    }
}
