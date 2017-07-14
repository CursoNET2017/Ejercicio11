using System.Collections.Generic;

namespace Ejercicio11
{
    public interface IRecetaRepository
    {
        void Actualizar(Receta recipe);
        void Borrar(string Nombre);
        Receta DevolverReceta(string Nombre);
        IList<Receta> DevolverRecetario();
        void GuardarReceta(Receta NuevaReceta);
    }
}