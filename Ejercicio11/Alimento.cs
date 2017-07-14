using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Alimento
    {
        public String nombre { get; set; }
        public float peso { get; set; }
        public bool calentado { get; set; }
        public Alimento()
        {
            this.peso = 0;
            this.calentado = false;
        }
        public Alimento(float _peso, bool _calentado)
        {
            this.peso = _peso;
            this.calentado = _calentado;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            if (((Alimento)obj).nombre == null)
            {
                if (this.nombre != null)
                    return false;
            }
            else
            {
                if (!((Alimento)obj).nombre.Equals(this.nombre))
                {
                    return false;
                }
            }

            return ((Alimento)obj).calentado == this.calentado && ((Alimento)obj).peso == this.peso;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
