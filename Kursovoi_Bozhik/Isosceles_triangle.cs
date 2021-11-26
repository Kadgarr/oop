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
    class Isosceles_triangle:Triangle
    {
        public Isosceles_triangle(double length_a, double length_b, double angle) : base(length_a, length_b, angle)
        {

        }

        public override double Perimetr()
        {
            if ((angle/(PI / 180.0)).ToString() != "60")
            {
                return base.Perimetr();

            }
            else
            {
                length_b = length_a;
                return length_a * 3.0;
            }
        }
        public override double Area()
        {
            if (CheckTriangle(length_c))
            {
                
                string ang = (angle / (PI / 180)).ToString();
            
                if (ang == "60")
                {
                    double area = (Pow(length_a, 2) * Sqrt(3)) / 4;
                    length_b = length_a;
                    return area;
                }
                else
                {
                    double h = Sqrt(Pow(length_b, 2) - Pow(length_a / 2, 2));

                    double area = (length_a * h) / 2;
                  
                    if (CheckMistake(area))
                    {
                        return area;
                    }
                    else
                        return 0;
                    
                }
                    
                
            }
            else
                return 0;

        }
       
    }
        
    
}
