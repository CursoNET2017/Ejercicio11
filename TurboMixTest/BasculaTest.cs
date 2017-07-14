using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace TurboMixTest
{
    [TestClass]
    public class BasculaTest
    {
        [TestMethod]
        public void TestSumar()
        {
            IBasculaService pes = new BasculaService();

            Alimento a = new Alimento();
            a.peso = 25F;
            Alimento b = new Alimento();
            b.peso = 10.2F;

            float resultado1 = pes.Pesar(a);
            Assert.AreEqual(25F, resultado1);
            float resultado2 = pes.Pesar(b);
            Assert.AreEqual(10.2F, resultado2);

        }
    }
}
