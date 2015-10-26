using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreas
{
    public class Retangulo : FormasGeometricas
    {
        private double _largura;
        public double Largura
        {
            get
            { return _largura; }
            set
            {
                if (value > 0)
                {
                    _largura = value;
                }
            }
        }

        private double _altura;
        public double Altura
        {
            get
            { return _altura; }
            set
            {
                if (value > 0)
                {
                    _altura = value;
                }
            }
        }

        public override void CalcularArea()
        {
            this.Area = Largura * Altura;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = 2 * this._largura + 2 * this._altura;
        }
    }
}
