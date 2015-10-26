using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreas
{
    public class Paralelogramo : FormasGeometricas
    {
        private double _base;
        public double Base
        {
            get
            { return _base; }
            set
            {
                if (value > 0)
                {
                    _base = value;
                }
            }
        }

        private double _lado;
        public double Lado
        {
            get
            { return _lado; }
            set
            {
                if (value > 0)
                {
                    _lado = value;
                }
            }
        }

        public override void CalcularArea()
        {
            this.Area = this._lado * this._base;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = 4 * Math.Sqrt(Math.Pow(this._altura / 2, 2) + (Math.Pow(this._altura / this._base)));
        }
    }
    
}
