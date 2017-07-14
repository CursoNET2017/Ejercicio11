using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class CocinaService : ICocinaService
    {
        ////private static bool llamado = false;

        ////public void calentar(Alimento a, Alimento b)
        ////{
        ////    llamado = true;
        ////    // TODO
        ////}

        ////public static bool IsLlamado()
        ////{
        ////    return llamado;
        ////}

        public void Calentar(Alimento a, Alimento b)
        {
            a.calentado = true;
            b.calentado = true;
        }
    }
}
