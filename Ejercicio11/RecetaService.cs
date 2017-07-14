using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class RecetaService : IRecetaService
    {
        //public IRecetaRepository Repository { get; set; }//Con esto solo casca el test con un nullExcep
        private IRecetaRepository recetaRepository;

        public RecetaService(IRecetaRepository _recetaRepository)
        {
            this.recetaRepository = _recetaRepository;
        }

        public void Insertar(Receta _Receta)
        {
            recetaRepository.GuardarReceta(_Receta);
        }

        public Receta DevolverReceta(string Nombre)
        {
            return recetaRepository.DevolverReceta(Nombre);
        }
        public IList<Receta> DevolverRecetario()
        {
            return recetaRepository.DevolverRecetario();
        }

        public void Actualizar(Receta recipe)
        {
            recetaRepository.Actualizar(recipe);
        }
        public void Borrar(string Nombre)
        {
            recetaRepository.Borrar(Nombre);
        }
    }
}
