using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularAreas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Quadrado q = new Quadrado();
            q.Lado = 10;
            q.CalcularArea();
            Console.WriteLine(q.Area);
            Console.ReadKey();
        }
    }
}
