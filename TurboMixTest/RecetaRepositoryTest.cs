using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;
using System.Collections.Generic;

namespace TurboMixTest
{
    [TestClass]
    public class RecetaRepositoryTest
    {
        [TestMethod]
        public void TestGuardarReceta()
        {
            IRecetaRepository Repository = new RecetaRepository();
            IList<Receta> Recetario = Repository.DevolverRecetario();
            int i = Recetario.Count;
            Alimento c = new Alimento();
            c.peso = 14F;
            c.nombre = "Pollo";
            Alimento d = new Alimento();
            d.peso = 5F;
            d.nombre = "Curry";
            Receta recipe = new Receta(c, d);

            Repository.GuardarReceta(recipe);
            //mock.Setup(foo => foo.Add(It.IsInRange<int>(0, 10, Range.Inclusive))).Returns(true); 
            int e = Recetario.Count;

            Assert.AreEqual(e, i + 1);
        }
    }
}
