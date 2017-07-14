using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    //Tiene que pesar y cocinar
    public class TurboMixService : ITurboMixService
    {
        public IBasculaService Bascula { get; set; }
        public ICocinaService Cocina { get; set; }
        public IComprobarReceta SePuedeCocinar { get; set; }
        //public IRecetaRepository Repository { get; set; }

        //public TurboMixService(IBasculaService _Bascula, ICocinaService _Cocina, IComprobarReceta _SePuedeCocinar, IRecetaRepository _Repository)
        //{
        //    this.Bascula = _Bascula;
        //    this.Cocina = _Cocina;
        //    this.SePuedeCocinar = _SePuedeCocinar;
        //    this.Repository = _Repository;
        //}

        public TurboMixService(IBasculaService _Bascula, ICocinaService _Cocina, IComprobarReceta _SePuedeCocinar)
        {
            this.Bascula = _Bascula;
            this.Cocina = _Cocina;
            this.SePuedeCocinar = _SePuedeCocinar;
        }

        public Plato HacerComida(Alimento a, Alimento b)
        {
            float peso1 = Bascula.Pesar(a);
            float peso2 = Bascula.Pesar(b);

            Cocina.Calentar(a, b);

            return new Plato(a, b);

        }

        public Plato HacerComida(Alimento a, Alimento b, Receta recipe)
        {
            if (SePuedeCocinar.Comprobar(a, b, recipe))
            {
                float peso1 = Bascula.Pesar(a);
                float peso2 = Bascula.Pesar(b);

                Cocina.Calentar(a, b);

                return new Plato(a, b);
            }
            return null;
        }

        //public void InsertarReceta(Receta _Receta)
        //{
        //    Repository.GuardarReceta(_Receta);
        //}        
    }
}
