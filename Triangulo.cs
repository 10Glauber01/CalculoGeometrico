using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreas
{
    public class Triangulo : FormasGeometricas
    {
        private double _aresta;
        public double Aresta
        {
            get
            { return _aresta; }
            set
            {
                if (value > 0)
                {
                    _aresta = value;
                }
            }
        }
        
        public override void CalcularArea()
        {
            this.Area = (Math.Pow(this._aresta,2) * Math.Sqrt(3)) / 4;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = 3 * this._aresta;
        }
    }
    
}
                   
                   
                   