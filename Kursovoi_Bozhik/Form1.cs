using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace Kursovoi_Bozhik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        List<Triangle> triangles = new List<Triangle>();
        BinaryFormatter formatter = new BinaryFormatter();


        //КНОПКИ ОБЧИСЛЕННЯ ПРЯМОКУТНОГО ТРИКУТНИКА
        private void button_area_priam_Click(object sender, EventArgs e)
        {
           
            try
            {
                Triangle triangle_right = new Right_triangle(double.Parse(textBox_priam_a.Text), double.Parse(textBox_priam_b.Text), double.Parse(textBox_priam_angle.Text));
                textBox1.Text = String.Format("{0:f3}", triangle_right.Area());


                //comboBox1.Items.Add($"Площадь: {triangle_right.Area()} --- Периметр: {triangle_right.Perimetr()}");
                //triangle.Add(triangle_right);


            }
            catch
            {
                MessageBox.Show("Введіть коректні дані!", "Помилка!");
            }

        }

        private void button_perim_priam_Click(object sender, EventArgs e)
        {
            
            try
            {
                Triangle triangle_right = new Right_triangle(double.Parse(textBox_priam_a.Text), double.Parse(textBox_priam_b.Text), double.Parse(textBox_priam_angle.Text));
                textBox6.Text = String.Format("{0:f3}", triangle_right.Perimetr());


            }
            catch(Exception ex)
            {
                MessageBox.Show("Введіть коректні дані!", "Помилка!");
            }
         
        }

      

        //КНОПКИ ОБЧИСЛЕННЯ РІВНОСТОРОННЬОГО ТРИКУТНИКА
        private void button_area_rivn_Click(object sender, EventArgs e)
        {
           
            try
            {
                Triangle triangle_equil = new Equilateral_triangle(double.Parse(textBox_rivn_a.Text), double.Parse(textBox_rivn_a.Text), double.Parse(textBox_rivn_angle.Text));
                textBox2.Text = String.Format("{0:f3}", triangle_equil.Area());

            }
            catch
            {
                MessageBox.Show("Введіть коректні дані!", "Помилка!");
            }
        }

        private void button_perim_rivn_Click(object sender, EventArgs e)
        {
           
            try
            {
                Triangle triangle_equil = new Equilateral_triangle(double.Parse(textBox_rivn_a.Text), double.Parse(textBox_rivn_a.Text), double.Parse(textBox_rivn_angle.Text));
                textBox5.Text = String.Format("{0:f3}", triangle_equil.Perimetr());

            }
            catch
            {
                MessageBox.Show("Введіть коректні дані!", "Помилка!");
            }
        }


        //КНОПКИ ОБЧИСЛЕННЯ РІВНОБЕДРЕНОГО ТРИКУТНИКА
        private void button_area_rivnobed_Click(object sender, EventArgs e)
        {
            
            try
            {
                Triangle triangle_isos = new Isosceles_triangle(double.Parse(textBox15.Text), double.Parse(textBox14.Text), double.Parse(textBox_rivnobed_angle.Text));
                textBox3.Text = String.Format("{0:f3}", triangle_isos.Area());

            }
            catch
            {
                MessageBox.Show("Введіть коректні дані!", "Помилка!");
            }
        }

        private void button_perim_rivnobed_Click(object sender, EventArgs e)
        {
           
            try
            {
                Triangle triangle_isos = new Isosceles_triangle(double.Parse(textBox15.Text), double.Parse(textBox14.Text), double.Parse(textBox_rivnobed_angle.Text));
                textBox4.Text = String.Format("{0:f3}", triangle_isos.Perimetr());

            }
            catch
            {
                MessageBox.Show("Введіть коректні дані!", "Помилка!");
            }
        }


        //КНОПКИ ОЧИЩЕННЯ ПОЛІВ
        private void button_clear_2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox5.Clear();
            textBox_rivn_a.Clear();
        }
        private void but_clear_1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox6.Clear();
            textBox_priam_a.Clear();
            textBox_priam_b.Clear();
        }
        private void button_clear_3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox_rivnobed_angle.Clear();
            textBox15.Clear();
            textBox14.Clear();
        }

        //КНОПКИ ГЕНЕРУВАННЯ ЧИСЕЛ
        private void but_gen_1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox_priam_a.Text = rand.Next(0,20).ToString();
            textBox_priam_b.Text = rand.Next(0, 20).ToString();
        }

        private void but_gen_2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox_rivn_a.Text = rand.Next(0, 20).ToString();
        }

        private void but_gen_3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox15.Text = rand.Next(0, 20).ToString();
            textBox14.Text= rand.Next(0, 20).ToString();
            textBox_rivnobed_angle.Text = rand.Next(1, 179).ToString();

        }

        //КНОПКИ ЗАВАНТАЖЕННЯ ДАНИХ З ФАЙЛУ ПРЯМОКУТНОГО ТРИКУТНИКА
        private void but_upload_priam_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "triangles";
            if (triangles.Count != 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                using (FileStream fs = new FileStream("triangle.dat", FileMode.OpenOrCreate, FileAccess.Write))
                {

                    formatter.Serialize(fs, triangles);
                     
                    MessageBox.Show("Об'єкт серіалізовано");
                }
            }
            else
                MessageBox.Show("Додайте до спику хоча б один елемент!","Помилка");
           
        }

        private void but_downoload_priam_Click(object sender, EventArgs e)
        {
            if (File.Exists("triangle.dat"))
            {
                
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream("triangle.dat", FileMode.Open, FileAccess.Read))
                    {
                        triangles = (List<Triangle>)formatter.Deserialize(fs);

                    }
                    foreach (Triangle tr in triangles)
                    {

                        comboBox1.Items.Add($"Площина: {String.Format("{0:f2}", tr.Area())}; кут: {tr.angle / (PI / 180)}");

                    }
                    MessageBox.Show("Об'єкт завантажено до програми");
                }
               
            }
            else
            {
                MessageBox.Show("Такого файла не існує!","Помилка");
            }
            
            

        }

        //ДОДАВАННЯ ДО СПИСКУ ПРЯМОКУТНОГО ТРИКУТНИКА
        private void but_add_priam_Click(object sender, EventArgs e)
        {
            try
            {
                Triangle triangle_right = new Right_triangle(double.Parse(textBox_priam_a.Text), double.Parse(textBox_priam_b.Text), double.Parse(textBox_priam_angle.Text));
                double S = triangle_right.Area();

                if (S > 0)
                {
                  
                    triangles.Add(triangle_right);
                    comboBox1.Items.Add($"Площина:{String.Format("{0:f2}", triangle_right.Area())}; кут: {triangle_right.angle / (PI / 180)} ");
                    MessageBox.Show("Трикутник додано до списку!");
                }
                else
                {
                    MessageBox.Show("Площина дорівнює нулю!","Помилка");
                }
                
            }
            catch
            {
                MessageBox.Show("Некоректні дані","Помилка!");
            }
        }
        //ДОДАВАННЯ ДО СПИСКУ РІВНОСТОРОННЬОГО ТРИКУТНИКА
        private void but_add_rivn_Click(object sender, EventArgs e)
        {
            try
            {
                Triangle triangle_Equilateral = new Equilateral_triangle(double.Parse(textBox_rivn_a.Text), double.Parse(textBox_rivn_a.Text), double.Parse(textBox_rivn_angle.Text));
                double S = triangle_Equilateral.Area();

                if (S > 0)
                {

                    triangles.Add(triangle_Equilateral);
                    comboBox1.Items.Add($"Площина: {String.Format("{0:f2}", triangle_Equilateral.Area())}; кут: {triangle_Equilateral.angle / (PI / 180)} ");
                    MessageBox.Show("Трикутник додано до списку!");
                }
                else
                {
                    MessageBox.Show("Площина дорівнює нулю!", "Помилка");
                }

            }
            catch
            {
                MessageBox.Show("Некоректні дані", "Помилка!");
            }
        }
        //ДОДАВАННЯ ДО СПИСКУ РІВНОБЕДРЕННОГО ТРИКУТНИКА
        private void but_add_rivnobed_Click(object sender, EventArgs e)
        {
            try
            {
                Triangle triangle_Isosceles = new Isosceles_triangle(double.Parse(textBox15.Text), double.Parse(textBox14.Text), double.Parse(textBox_rivnobed_angle.Text));
                double S = triangle_Isosceles.Area();

                if (S > 0)
                {

                    triangles.Add(triangle_Isosceles);
                    comboBox1.Items.Add($"Площина: {String.Format("{0:f2}", triangle_Isosceles.Area())}; кут: {triangle_Isosceles.angle / (PI / 180)} ");
                    MessageBox.Show("Трикутник додано до списку!");
                }
                else
                {
                    MessageBox.Show("Площина дорівнює нулю!", "Помилка");
                }

            }
            catch
            {
                MessageBox.Show("Некоректні дані", "Помилка!");
            }
        }


        //ЗМІНА ЕЛЕМЕНТУ СПИСКУ ТРИКУТНИКІВ
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = 0;
            index = comboBox1.SelectedIndex;
            if (index != -1)
            {
                string ang = (triangles[index].angle / (PI / 180.0)).ToString();
                
                if (ang == "90")
                {
                    textBox_priam_a.Text = triangles[index].length_a.ToString();
                    textBox_priam_b.Text = triangles[index].length_b.ToString();
                    textBox1.Text = String.Format("{0:f3}",triangles[index].Area());
                    textBox6.Text = String.Format("{0:f3}", triangles[index].Perimetr());
                }
                else
                if (ang == "60")
                {
                    Console.WriteLine(ang);
                    textBox_rivn_a.Text = triangles[index].length_a.ToString();
                    textBox2.Text = String.Format("{0:f3}",triangles[index].Area());
                    textBox5.Text = String.Format("{0:f3}", triangles[index].Perimetr());
                }
                else
                if (ang!="60" && ang!="90")
                {
                    textBox15.Text = triangles[index].length_a.ToString();
                    textBox14.Text = triangles[index].length_b.ToString();
                    textBox3.Text = String.Format("{0:f3}", triangles[index].Area());
                    textBox4.Text = String.Format("{0:f3}", triangles[index].Perimetr());
                }
                
            }

           
        }

        //ЗБЕРЕЖЕННЯ ЗМІН ЕЛЕМЕНТУ СПИСКУ ТРИКУТНИКІВ
        private void but_save_Click(object sender, EventArgs e)
        {
            int index = 0;
            index = comboBox1.SelectedIndex;
            if (index != -1)
            {
                Triangle triangle_right = new Right_triangle(double.Parse(textBox_priam_a.Text), double.Parse(textBox_priam_b.Text), double.Parse(textBox_priam_angle.Text));
                double S = triangle_right.Area();

                if (S > 0)
                {
                    triangles[index].length_a = double.Parse(textBox_priam_a.Text);
                    triangles[index].length_b = double.Parse(textBox_priam_b.Text);
                    textBox1.Text = String.Format("{0:f3}", triangles[index].Area());
                    textBox6.Text = String.Format("{0:f3}", triangles[index].Perimetr());
                    comboBox1.Items[index] = $"Площина: {triangles[index].Area()}; кут: {triangles[index].angle / (PI / 180)}";
                }
                else
                {
                    MessageBox.Show("Некоректний формат даних!", "Помилка");
                }
            }
            else MessageBox.Show("Оберіть елемент списку!","Помилка");
        }
        private void but_save_rivn_Click(object sender, EventArgs e)
        {
            int index = 0;
            index = comboBox1.SelectedIndex;
            if (index != -1)
            {
                Triangle triangle_right = new Equilateral_triangle(double.Parse(textBox_rivn_a.Text), double.Parse(textBox_rivn_a.Text), double.Parse(textBox_rivn_angle.Text));
                double S = triangle_right.Area();

                if (S > 0)
                {
                    triangles[index].length_a = double.Parse(textBox_priam_a.Text);
                    triangles[index].length_b = double.Parse(textBox_priam_b.Text);
                    textBox1.Text = String.Format("{0:f3}", triangles[index].Area());
                    textBox6.Text = String.Format("{0:f3}", triangles[index].Perimetr());
                    comboBox1.Items[index] = $"Площина: {triangles[index].Area()}; кут: {triangles[index].angle / (PI / 180)}";
                }
                else
                {
                    MessageBox.Show("Некоректний формат даних!", "Помилка");
                }
            }
            else MessageBox.Show("Оберіть елемент списку!", "Помилка");
        }
        private void but_save_rivnobed_Click(object sender, EventArgs e)
        {
            int index = 0;
            index = comboBox1.SelectedIndex;
            if (index != -1)
            {
                Triangle triangle_right = new Isosceles_triangle(double.Parse(textBox14.Text), double.Parse(textBox15.Text), double.Parse(textBox_rivnobed_angle.Text));
                double S = triangle_right.Area();

                if (S > 0)
                {
                    triangles[index].length_a = double.Parse(textBox_priam_a.Text);
                    triangles[index].length_b = double.Parse(textBox_priam_b.Text);
                    textBox1.Text = String.Format("{0:f3}", triangles[index].Area());
                    textBox6.Text = String.Format("{0:f3}", triangles[index].Perimetr());
                    comboBox1.Items[index] = $"Площина: {triangles[index].Area()}; кут: {triangles[index].angle / (PI / 180)}";
                }
                else
                {
                    MessageBox.Show("Некоректний формат даних!", "Помилка");
                }
            }
            else MessageBox.Show("Оберіть елемент списку!", "Помилка");
        }

    }
}
