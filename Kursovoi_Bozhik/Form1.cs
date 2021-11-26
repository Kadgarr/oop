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
                if ((triangle_isos.angle / (PI / 180.0)).ToString() == "60")
                {
                    MessageBox.Show("Цей трикутник є правильним!", "Попередження");
                }
                else
                if ((triangle_isos.angle / (PI / 180.0)).ToString() == "90")
                {
                    MessageBox.Show("Цей трикутник є прямокутним!", "Попередження");
                }
                else
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
                if ((triangle_isos.angle / (PI / 180.0)).ToString() == "60")
                {
                    MessageBox.Show("Цей трикутник є правильним!", "Попередження");
                }
                else
                if ((triangle_isos.angle / (PI / 180.0)).ToString() == "90")
                {
                    MessageBox.Show("Цей трикутник є прямокутним!", "Попередження");
                }
                else
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
            
            if (triangles.Count != 0)
            {
                try
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                        {

                            formatter.Serialize(fs, triangles);
                            MessageBox.Show("Об'єкт серіалізовано");
                        }
                }
                catch
                {
                    MessageBox.Show("Помилка завантаження файлу!", "Помилка");
                }

            }
            else
                MessageBox.Show("Додайте до спику хоча б один елемент!","Помилка");
           
        }
        private void but_downoload_priam_Click(object sender, EventArgs e)
        {

                if (comboBox1.Items.Count != 0)
                {
                    comboBox1.Items.Clear();
                }

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                        {
                            triangles = (List<Triangle>)formatter.Deserialize(fs);
                        }
                        foreach (Triangle tr in triangles)
                        {
                       

                            if (tr.GetType()==typeof(Right_triangle))
                                comboBox1.Items.Add($"Площина: {String.Format("{0:f2}", tr.Area())}; кут: {tr.angle / (PI / 180)} -прямокут.");
                            else
                            if(tr.GetType() == typeof(Equilateral_triangle))
                                comboBox1.Items.Add($"Площина: {String.Format("{0:f2}", tr.Area())}; кут: {tr.angle / (PI / 180)} -правильний.");
                            else
                            if(tr.GetType()==typeof(Isosceles_triangle))
                                comboBox1.Items.Add($"Площина: {String.Format("{0:f2}", tr.Area())}; кут: {tr.angle / (PI / 180)} -рівнобедр.");

                        }

                        MessageBox.Show("Об'єкт завантажено до програми");
                    }
                    catch
                    {
                        MessageBox.Show("Помилка завантаження файлу!","Помилка");
                    }
                    
                }
            //else
            //{
            //    MessageBox.Show("Такого файла не існує!","Помилка");
            //}
            
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

                    comboBox1.Items.Add($"Площина:{String.Format("{0:f2}", triangle_right.Area())}; кут: {triangle_right.angle / (PI / 180)} -прямокут.");
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
                    comboBox1.Items.Add($"Площина: {String.Format("{0:f2}", triangle_Equilateral.Area())}; кут: {triangle_Equilateral.angle / (PI / 180)} - правильний.");
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


                    if ((triangle_Isosceles.angle / (PI / 180.0)).ToString() == "60")
                    {
                        MessageBox.Show("Цей трикутник є правильним!", "Попередження");
                    }
                    else
                    if((triangle_Isosceles.angle / (PI / 180.0)).ToString() == "90")
                    {
                        MessageBox.Show("Цей трикутник є прямокутним!", "Попередження");
                    }
                    else
                    {
                        triangles.Add(triangle_Isosceles);
                        comboBox1.Items.Add($"Площина: {String.Format("{0:f2}", triangle_Isosceles.Area())}; кут: {triangle_Isosceles.angle / (PI / 180)} -рівнобедр.");
                        MessageBox.Show("Трикутник додано до списку!");
                    }
                    
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
                    but_save_priam.Enabled = true;
                    but_save_rivn.Enabled = false;
                    but_save_rivnobed.Enabled = false;
                    textBox_priam_a.Text = triangles[index].length_a.ToString();
                    textBox_priam_b.Text = triangles[index].length_b.ToString();
                    textBox1.Text = String.Format("{0:f3}",triangles[index].Area());
                    textBox6.Text = String.Format("{0:f3}", triangles[index].Perimetr());
                }
                else
                if (ang == "60")
                {
                    but_save_priam.Enabled = false;
                    but_save_rivn.Enabled = true;
                    but_save_rivnobed.Enabled = false;
                    Console.WriteLine(ang);
                    textBox_rivn_a.Text = triangles[index].length_a.ToString();
                    textBox2.Text = String.Format("{0:f3}",triangles[index].Area());
                    textBox5.Text = String.Format("{0:f3}", triangles[index].Perimetr());
                }
                else
                if (ang!="60" && ang!="90")
                {
                    but_save_priam.Enabled = false;
                    but_save_rivn.Enabled = false;
                    but_save_rivnobed.Enabled = true;
                    textBox15.Text = triangles[index].length_a.ToString();
                    textBox14.Text = triangles[index].length_b.ToString();
                    textBox3.Text = String.Format("{0:f3}", triangles[index].Area());
                    textBox4.Text = String.Format("{0:f3}", triangles[index].Perimetr());
                    textBox_rivnobed_angle.Text = (triangles[index].angle/(PI/180)).ToString();
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
                    comboBox1.Items[index] = $"Площина: {String.Format("{0:f2}", triangles[index].Area())}; кут: {triangles[index].angle / (PI / 180)} -прямокут.";
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
                    triangles[index].length_a = double.Parse(textBox_rivn_a.Text);
                    triangles[index].length_b = double.Parse(textBox_rivn_a.Text);
                    textBox2.Text = String.Format("{0:f3}", triangles[index].Area());
                    textBox5.Text = String.Format("{0:f3}", triangles[index].Perimetr());
                    comboBox1.Items[index] = $"Площина: {String.Format("{0:f2}", triangles[index].Area())}; кут: {triangles[index].angle / (PI / 180)} -правильний.";
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
                    triangles[index].length_a = double.Parse(textBox15.Text);
                    triangles[index].length_b = double.Parse(textBox14.Text);
                    textBox3.Text = String.Format("{0:f3}", triangles[index].Area());
                    textBox4.Text = String.Format("{0:f3}", triangles[index].Perimetr());
                    comboBox1.Items[index] = $"Площина: {String.Format("{0:f2}", triangles[index].Area())}; кут: {triangles[index].angle / (PI / 180)} -рівнобедр.";
                }
                else
                {
                    MessageBox.Show("Некоректний формат даних!", "Помилка");
                }
            }
            else MessageBox.Show("Оберіть елемент списку!", "Помилка");
        }

        //ОБЧИСЛЕННЯ ЗАГАЛЬНОЇ ПЛОЩИНИ УСІХ ТРИКУТНИКІВ
        private void button_priam_area_Click(object sender, EventArgs e)
        {
            double summ = 0;
            if (triangles.Count > 0)
            {
                foreach (var tr in triangles)
                {
                    
                    if (tr.GetType() == typeof(Right_triangle))
                        summ += tr.Area();
                   
                }
                textBox_priam_area.Text = String.Format("{0:f3}",summ);
            }
            else
                MessageBox.Show("Список є пустим!","Помилка");
        }
        private void button_rivn_area_Click(object sender, EventArgs e)
        {
            double summ = 0;
            if (triangles.Count > 0)
            {
                foreach (var tr in triangles)
                {
                    string ang = (tr.angle / (PI / 180.0)).ToString();

                    if (tr.GetType() == typeof(Equilateral_triangle) || (tr.GetType() == typeof(Isosceles_triangle) && ang == "60"))
                        summ += tr.Area();
                  
                }
                textBox_rivn_area.Text = String.Format("{0:f3}", summ);
            }
            else
                MessageBox.Show("Список є пустим!", "Помилка");
        }

        private void button_rivnobed_area_Click(object sender, EventArgs e)
        {
            double summ = 0;
            if (triangles.Count > 0)
            {
                foreach (var tr in triangles)
                {
                    string ang = (tr.angle / (PI / 180.0)).ToString();
                    if (tr.GetType() == typeof(Isosceles_triangle)&&ang!="60")
                        summ += tr.Area();

                }
                textBox_rivnobed_area.Text = String.Format("{0:f3}", summ);
            }
            else
                MessageBox.Show("Список є пустим!", "Помилка");
        }


        //КНОПКА ВИДАЛЕННЯ ТРИКУТНИКА ЗІ СПИСКУ
        private void button_delete_Click(object sender, EventArgs e)
        {
            int index = 0;
            index = comboBox1.SelectedIndex;
            if (index != -1)
            {
                if (comboBox1.Items.Count != 0)
                {
                    triangles.RemoveAt(index);
                    comboBox1.Items.RemoveAt(index);
                }
                else
                {
                    MessageBox.Show("Додайте до списку елемент!", "Помилка");
                }
               
            }
        }

      
    }
}
