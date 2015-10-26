using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreas
{
    public abstract class FormasGeometricas
    {
        private double _area;
        private double _perimetro;

        public double Area
        {
            get
            {
                return _area;
            }
            set
            {
                _area = value;
            }

        }

        public double Perimetro
        {
            get
            {
                return _perimetro;
            }
            set
            {
                _perimetro = value;
            }
        }

        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();
    }
}
