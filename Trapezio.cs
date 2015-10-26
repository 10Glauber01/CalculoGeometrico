using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreas
{
    public class Trapezio : FormasGeometricas
    {
        private double _baseMenor;
        public double BaseMenor
        {
            get
            { return _baseMenor; }
            set
            {
                if (value > 0)
                {
                    _baseMenor = value;
                }
            }
        }
        private double _baseMaior;
        public double BaseMaior
        {
            get
            { return _baseMaior; }
            set
            {
                if (value > 0)
                {
                    _baseMaior = value;
                }
            }
        }
        private double _altura;
        public double Altura
        {
            get
            {
                return _altura;
            }
            set
            {
                if (value > 0)
                {
                    _altura = value;
                }
            }
        }

        private double _lado1;
        public double Lado
        {
            get
            { return _lado1; }
            set
            {
                if (value > 0)
                {
                    _lado1 = value;
                }
            }
        }

        private double _lado2;
        public double Lado
        {
            get
            { return _lado2; }
            set
            {
                if (value > 0)
                {
                    _lado2 = value;
                }
            }
        }



        public override void CalcularArea()
        {
            this.Area = ((this._baseMenor + this._baseMaior) * this._altura) / 2;
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = this._baseMenor + this._baseMaior + this._lado1 + this._lado2;

        }
    }


}
