using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;
using System.Collections.Generic;
using Moq;

namespace TurboMixTest
{
    [TestClass]
    public class RecetaServiceIntegracionTest
    {
        IRecetaRepository Repository;
        IRecetaService recetaService;
        Receta recipe;

        [TestInitialize]
        public void Init()
        {
            Repository = new RecetaRepository();
            recetaService = new RecetaService(Repository);
            recipe = new Receta();
        }

        [TestMethod]
        public void TestInsertarReceta()
        {            
            recetaService.Insertar(recipe);
        }

        [TestMethod]
        public void TestDevolverReceta()
        {
            recetaService.DevolverReceta("Pollo al Curry");
        }

        [TestMethod]
        public void TestDevolverRecetario()
        {
            recetaService.DevolverRecetario();
        }

        [TestMethod]
        public void TestActualizar()
        {
            recetaService.Actualizar(recipe);
        }

        [TestMethod]
        public void TestBorrar()
        {
            recetaService.Borrar("Pollo al Curry");
        }
    }
}
