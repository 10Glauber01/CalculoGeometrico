using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreas
{
    public class Losango : FormasGeometricas
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
            this.Area = (this._largura * this._altura) / 2;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = 4 * Math.Sqrt(Math.Pow(this._largura / 2, 2) + (Math.Pow(this._altura / 2, 2)));
        }
    }
}