using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class RecetaRepository : IRecetaRepository
    {
        //public static List<Receta> Recetario = new List<Receta>();
        private IList<Receta> Recetario = new List<Receta>();//Hay que hacerlo mas general, con las interfaces

        public void GuardarReceta(Receta NuevaReceta)
        {
            Recetario.Add(NuevaReceta);
        }

        public Receta DevolverReceta(string Nombre)
        {
            Receta recipe = new Receta();
            return recipe;
        }
        public IList<Receta> DevolverRecetario()
        {
            return Recetario;
        }

        public void Actualizar(Receta recipe)
        {

        }
        public void Borrar(string Nombre)
        {

        }

    }
}
