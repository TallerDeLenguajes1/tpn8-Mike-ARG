using System;
using System.Collections.Generic;
using System.Text;

namespace tp7
{
    public class Calculadora
    {
        private float numero1;

        public float Numero1
        {
            get;
            set;
        }
        
        private float numero2;

        public float Numero2
        {
            get;
            set;
        }

        public float Suma(float Numero1, float Numero2)
        {
            return Numero1 + Numero2;
        }

        public float Resta(float Numero1, float Numero2)
        {
            return Numero1 - Numero2;
        }

        public float Multiplicacion(float Numero1, float Numero2)
        {
            return Numero1 * Numero2;
        }

        public float Division(float Numero1, float Numero2)
        {
            if (Numero2 == 0)
            {
                return -9999;
            }

            return Numero1 / Numero2;
        }


    }
}
