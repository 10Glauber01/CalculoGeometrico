using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreas
{
    public class Circulo : FormasGeometricas
    {
        private double _raio;
        public double Raio
        {
            get
            { return _raio; }
            set
            {
                if (value > 0)
                {
                    _raio = value;
                }
            }
        }



        public override void CalcularArea()
        {
            this.Area = 3.14 * Math.Pow(this._raio, 2);
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = 2 * 3.14 * this._raio;
        }
    }

}
