using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Plato
    {
        private Alimento a;
        private Alimento b;
        public Plato(Alimento a, Alimento b)
        {
            this.a = a;
            this.b = b;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!this.GetType().Equals(obj.GetType()))//Sera si es distinto no??
            {
                return false;
            }

            if (this.a == null && ((Plato)obj).a != null)
            {
                return false;
            }
            if (this.a != null && !this.a.Equals(((Plato)obj).a))
            {
                return false;
            }

            if (this.b == null && ((Plato)obj).b != null)
            {
                return false;
            }
            if (this.b != null && !this.b.Equals(((Plato)obj).b))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return a + " al " + b;
        }
    }
}
