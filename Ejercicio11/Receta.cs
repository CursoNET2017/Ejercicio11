using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Receta
    {
        public string nombre { get; set; }
        public Alimento a { get; set; }
        public Alimento b { get; set; }

        public Receta(Alimento a, Alimento b)
        {
            this.a = a;
            this.b = b;
        }

        public Receta()
        {
        }
    }
}
