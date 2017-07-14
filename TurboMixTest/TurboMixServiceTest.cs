using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;
using Moq;

namespace TurboMixTest
{
    [TestClass]
    public class TurboMixServiceTest
    {
        [TestMethod]
        public void TestHacerComidaSinReceta()
        {
            var mockBasculaService = new Mock<IBasculaService>();
            var mockCocinaService = new Mock<ICocinaService>();

            mockBasculaService.Setup(bascula => bascula.Pesar(It.IsAny<Alimento>()))
                .Returns((Alimento p) => p.peso);
            mockBasculaService.Setup(bascula => bascula.Pesar(It.IsAny<Alimento>()))
                .Returns((Alimento p) => p.peso);

            mockCocinaService.Setup(cocina => cocina.Calentar(It.IsAny<Alimento>(), It.IsAny<Alimento>()))
                .Callback(
                (Alimento p1, Alimento p2) => { p1.calentado = true; p2.calentado = true; });

            IBasculaService basculaService = mockBasculaService.Object;
            ICocinaService cocinaService = mockCocinaService.Object;

            Alimento a = new Alimento();
            a.peso = 25F;
            a.nombre = "Pollo";
            Alimento b = new Alimento();
            b.peso = 10.2F;
            b.nombre = "Curry";
            TurboMixService sut = new TurboMixService(basculaService, cocinaService, null);

            Plato resultado = sut.HacerComida(a, b);

            mockBasculaService.Verify(bascula => bascula.Pesar(It.IsAny<Alimento>()), Times.AtLeast(2));
            mockCocinaService.Verify(cocina => cocina.Calentar(It.IsAny<Alimento>(), It.IsAny<Alimento>()), Times.Once);

            Plato mplato = new Plato(a, b);
            Assert.AreEqual(mplato, resultado);
        }
    }
}

////if ("OK".Equals(resultado)) ==> Con este orden no casca si resultado es = null
