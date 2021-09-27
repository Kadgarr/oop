using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoi_Bozhik
{
    [Serializable]
    class Right_triangle:Triangle
    {
        public Right_triangle(double length_a, double length_b, double angle) : base(length_a, length_b, angle)
        {

        }

        public override double Perimetr()
        {
            return base.Perimetr();
        }

        public override double Area()
        {
           // Console.WriteLine(length_b);
            double area = 0;
            if (CheckTriangle(length_c))
            {
                area = (length_a * length_b) / 2;
                if (CheckMistake(area))
                {
                    return area;
                }
                else
                    return 0;
            }
            else {
                return 0;
            }
            
           
        }
      
    }
}
