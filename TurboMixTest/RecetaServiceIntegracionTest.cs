using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio11;
using System.Collections.Generic;
using Moq;
using Microsoft.Practices.Unity;

namespace TurboMixTest
{
    [TestClass]
    public class RecetaServiceIntegracionTest
    {
        //IRecetaRepository Repository;
        //IRecetaService recetaService;
        Receta recipe;
        IUnityContainer container;
        IRecetaService sut;


        [TestInitialize]
        public void Init()
        {
            //Repository = new RecetaRepository();
            //recetaService = new RecetaService(Repository);
            recipe = new Receta();

            container = new UnityContainer();            
            container.RegisterType<IRecetaRepository, RecetaRepository>();
            container.RegisterType<IRecetaService, RecetaService>();
            sut = container.Resolve<IRecetaService>();//IMPORTANTE desde donde se ejecutan no es la interfaz
        }

        [TestMethod]
        public void TestInsertarReceta()
        {
            sut.Insertar(recipe);
        }

        [TestMethod]
        public void TestDevolverReceta()
        {
            sut.DevolverReceta("Pollo al Curry");
        }

        [TestMethod]
        public void TestDevolverRecetario()
        {
            sut.DevolverRecetario();
        }

        [TestMethod]
        public void TestActualizar()
        {
            sut.Actualizar(recipe);
        }

        [TestMethod]
        public void TestBorrar()
        {
            sut.Borrar("Pollo al Curry");
        }
    }
}
