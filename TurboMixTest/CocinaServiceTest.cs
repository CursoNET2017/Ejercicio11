using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace TurboMixTest
{
    [TestClass]
    public class CocinaServiceTest
    {
        [TestMethod]
        public void TestCalentar()
        {
            ICocinaService sut = new CocinaService();
            Alimento a = new Alimento();
            Alimento b = new Alimento();

            sut.Calentar(a, b);

            Assert.IsTrue(a.calentado);//Verifica de una vez que ambos estan calentados(El mismo tipo de verificación)
            Assert.IsTrue(b.calentado);
        }
    }
}