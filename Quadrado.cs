using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreas
{
    public class Quadrado : FormasGeometricas
    {
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
            this.Area =this._lado*this._lado;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = 4 *this._lado;
        }
    }
}
