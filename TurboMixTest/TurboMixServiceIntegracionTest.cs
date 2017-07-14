using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;

namespace TurboMixTest
{
    [TestClass]
    public class TurboMixServiceIntegracionTest
    {
        private Alimento a;
        private Alimento b;
        private IBasculaService basculaService;
        private ICocinaService cocinaService;

        [TestInitialize]
        public void Init()
        {
            basculaService = new BasculaService();
            cocinaService = new CocinaService();
            a = new Alimento();
            a.peso = 25F;
            a.nombre = "Pollo";
            b = new Alimento();
            b.peso = 10.2F;
            b.nombre = "Curry";
        }

        [TestMethod]
        public void TestHacerComida()
        {
            //IBascula basculaService = new BasculaService();
            //ICocina cocinaService = new CocinaService();
            //Alimento a = new Alimento();
            //a.peso = 25F;
            //a.nombre = "Pollo";
            //Alimento b = new Alimento();
            //b.peso = 10.2F;
            //b.nombre = "Curry";

            //****
            Alimento c = new Alimento();
            c.peso = 14F;
            c.nombre = "Pollo";
            Alimento d = new Alimento();
            d.peso = 5F;
            d.nombre = "Curry";
            Receta recipe = new Receta(c, d);

            IComprobarReceta compro = new ComprobarReceta();

            //***
            TurboMixService sut = new TurboMixService(basculaService, cocinaService, compro);

            Plato resultado = sut.HacerComida(a, b, recipe);//***+++***
            Plato mplato = new Plato(a, b);
            Assert.AreEqual(mplato, resultado);
        }
    }
}

////if ("OK".Equals(resultado)) ==> Con este orden no casca si resultado es = null
