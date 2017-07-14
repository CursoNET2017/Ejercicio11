using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class ComprobarReceta : IComprobarReceta
    {
        public bool Comprobar(Alimento a, Alimento b, Receta _receta)
        {
            //if (a.calentado == true || b.calentado == true)//Entiendo que es redundante ya que esto ahora se comprueba con el equals. No va el equals...
            //{
            //    return false;
            //}
            //if (a.nombre != _receta.a.nombre || b.nombre != _receta.b.nombre)
            //{
            //    return false;
            //}
            if (a.peso < _receta.a.peso || b.peso < _receta.b.peso)
            {
                return false;
            }
            else
            {
                a.peso = _receta.a.peso;
                b.peso = _receta.b.peso;
            }

            if (!a.Equals(_receta.a) || !b.Equals(_receta.b))
            {
                return false;
            }

            return true;
        }
    }
}
