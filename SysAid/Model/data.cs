using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysAid.Model
{
    public class data
    {
        private float efectividad;
        private float residual;

        public data(float efectividad, float residual)
        {
            this.efectividad = efectividad;
            this.residual = residual;
        }

        public float Efectividad { get => efectividad; set => efectividad = value; }
        public float Residual { get => residual; set => residual = value; }

        public float calcularResidual(float riesgo)
        {
            float resultado;
            resultado = this.efectividad * riesgo;
            return resultado;
        }
    }
}