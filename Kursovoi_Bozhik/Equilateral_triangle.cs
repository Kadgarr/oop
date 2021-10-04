using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using System.Windows.Forms;

namespace Kursovoi_Bozhik
{
    [Serializable]
    class Equilateral_triangle: Triangle
    {
        public Equilateral_triangle(double length_a, double length_b, double angle) : base(length_a, length_b, angle)
        {
            this.length_a=length_a;
            this.length_b = length_a;
            length_c = length_a;
        }

        public override double Perimetr()
        {
            if (CheckTriangle(length_a))
            {
                double p = length_a * 3.0;
                if (CheckMistake(p))
                {
                    return p;
                }
                else
                    return 0;
            }
            else 
                return 0;
        }


        public override double Area()
        {
            if (CheckTriangle(length_c))
            {
                
                double area = (Pow(length_a, 2) * Sqrt(3)) / 4.0;
            
                if (CheckMistake(area))
                {
                    return area;
                }
                else
                    return 0;
            }
            else
                return 0;
        }
      
    }
}
