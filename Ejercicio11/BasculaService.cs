﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class BasculaService : IBasculaService
    {
        public float Pesar(Alimento a)
        {
            return a.peso;
        }
    }
}
