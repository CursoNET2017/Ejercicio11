using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;
using Moq;

namespace TurboMixTest
{
    [TestClass]
    public class RecetaServiceTest
    {

        [TestMethod]
        public void TestInsertar()
        {
            var mockRecetaRepository = new Mock<IRecetaRepository>();
            Receta recipe = new Receta();
            
            IRecetaService sut = new RecetaService(mockRecetaRepository.Object);//invoco una instancia con el simulado
            sut.Insertar(recipe);

            mockRecetaRepository.Verify(recetaRepository => recetaRepository.GuardarReceta(It.IsAny<Receta>()), Times.Once);

        }
    }
}
