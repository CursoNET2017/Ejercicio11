using System.Collections.Generic;

namespace Ejercicio11
{
    public interface IRecetaService
    {
        void Actualizar(Receta recipe);
        void Borrar(string Nombre);
        Receta DevolverReceta(string Nombre);
        IList<Receta> DevolverRecetario();
        void Insertar(Receta _Receta);
    }
}