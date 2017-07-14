namespace Ejercicio11
{
    public interface ITurboMixService
    {
        Plato HacerComida(Alimento a, Alimento b);
        Plato HacerComida(Alimento a, Alimento b, Receta recipe);
        //void InsertarReceta(Receta _Receta);
    }
}