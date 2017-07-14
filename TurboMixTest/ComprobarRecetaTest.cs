using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace TurboMixTest
{
    [TestClass]
    public class ComprobarRecetaTest
    {
        [TestMethod]
        public void TestComprobar()
        {
            Alimento a = new Alimento();
            a.peso = 25F;
            a.nombre = "Pollo";
            Alimento b = new Alimento();
            b.peso = 10.2F;
            b.nombre = "Curry";

            Alimento c = new Alimento();
            c.peso = 14F;
            c.nombre = "Pollo";
            Alimento d = new Alimento();
            d.peso = 5F;
            d.nombre = "Curry";
            Receta recipe = new Receta(c, d);

            IComprobarReceta compro = new ComprobarReceta();

            bool salida = compro.Comprobar(a, b, recipe);

            Assert.IsTrue(compro.Comprobar(a, b, recipe));
        }
    }
}
