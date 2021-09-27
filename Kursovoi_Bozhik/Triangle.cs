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
    abstract class Triangle
    {
        internal double length_a;

        internal double length_b;

        internal double length_c;

        internal double angle;
        public Triangle(double length_a, double length_b,double angle)
        {
            this.length_a = length_a;
            this.length_b = length_b;
            this.angle = angle * (PI / 180.0);
            this.length_c = Sqrt(Pow(length_a, 2) + Pow(length_b, 2) - 2 * length_b * length_a * Cos(this.angle));
            //Console.WriteLine(Sin(this.angle));
        }

        public bool CheckTriangle(double c)
        {
            
            if(((length_a+length_b>c && length_a+c>length_b && length_b + c > length_a)&&(length_a>0 && length_b>0 && c>0)) && (angle / (PI / 180) < 180&& angle / (PI / 180) > 0))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Такого трикутника не існує!", "Помилка!");
                return false;
            }
        }

        public virtual double Perimetr()
        {
            double p = 0;

            if (CheckTriangle(length_c))
            {
                p = length_c + length_a + length_b;
                if (CheckMistake(p))
                {
                    return p;
                }
                else
                    return 0;
            }
            else return 0;
          
           
        }

        public virtual double Area()
        {

            double area = 0;


            if (CheckTriangle(length_c))
            {
                area = (length_a * length_b * Sin(angle)) / 2;
               
                if (CheckMistake(area))
                {
                    return area;
                }
                else
                    return 0;
            }
            else return 0;
        }

        public bool CheckMistake(double a)
        {
            if (Double.IsNaN(a))
            {
                MessageBox.Show("a value is not-a-number (NaN)", "Ошибка");
                return false;
            }
            else
            if (Double.IsInfinity(a))
            {
                MessageBox.Show("a value is not-a-number (NaN)", "Ошибка");
                return false;
            }
            else
            if (a < double.MinValue || a > double.MaxValue)
            {
                MessageBox.Show("Значение результат выходит за диапазон значений!", "Ошибка");
                return false;
            }
            else
                return true;
        }
    }
}
