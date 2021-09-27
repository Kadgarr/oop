namespace Kursovoi_Bozhik
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_area_priam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_area_rivn = new System.Windows.Forms.Button();
            this.button_area_rivnobed = new System.Windows.Forms.Button();
            this.button_perim_rivnobed = new System.Windows.Forms.Button();
            this.button_perim_rivn = new System.Windows.Forms.Button();
            this.button_perim_priam = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox_priam_a = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_priam_b = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_priam_angle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_rivn_angle = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_rivn_a = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_rivnobed_angle = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.but_clear_1 = new System.Windows.Forms.Button();
            this.button_clear_2 = new System.Windows.Forms.Button();
            this.button_clear_3 = new System.Windows.Forms.Button();
            this.but_gen_1 = new System.Windows.Forms.Button();
            this.but_gen_2 = new System.Windows.Forms.Button();
            this.but_gen_3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.but_upload_priam = new System.Windows.Forms.Button();
            this.but_downoload_priam = new System.Windows.Forms.Button();
            this.but_add_priam = new System.Windows.Forms.Button();
            this.but_save_priam = new System.Windows.Forms.Button();
            this.but_save_rivn = new System.Windows.Forms.Button();
            this.but_add_rivn = new System.Windows.Forms.Button();
            this.but_save_rivnobed = new System.Windows.Forms.Button();
            this.but_add_rivnobed = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button_area_priam
            // 
            this.button_area_priam.Location = new System.Drawing.Point(208, 362);
            this.button_area_priam.Name = "button_area_priam";
            this.button_area_priam.Size = new System.Drawing.Size(102, 35);
            this.button_area_priam.TabIndex = 0;
            this.button_area_priam.Text = "Обчислити";
            this.button_area_priam.UseVisualStyleBackColor = true;
            this.button_area_priam.Click += new System.EventHandler(this.button_area_priam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Прямокутний трикутник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Рівносторонній трикутник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(899, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Рівнобедрений трикутник";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "S = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "P = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "P = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "S = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(826, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "P = ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(826, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "S = ";
            // 
            // button_area_rivn
            // 
            this.button_area_rivn.Location = new System.Drawing.Point(642, 362);
            this.button_area_rivn.Name = "button_area_rivn";
            this.button_area_rivn.Size = new System.Drawing.Size(102, 35);
            this.button_area_rivn.TabIndex = 12;
            this.button_area_rivn.Text = "Обчислити";
            this.button_area_rivn.UseVisualStyleBackColor = true;
            this.button_area_rivn.Click += new System.EventHandler(this.button_area_rivn_Click);
            // 
            // button_area_rivnobed
            // 
            this.button_area_rivnobed.Location = new System.Drawing.Point(987, 355);
            this.button_area_rivnobed.Name = "button_area_rivnobed";
            this.button_area_rivnobed.Size = new System.Drawing.Size(102, 35);
            this.button_area_rivnobed.TabIndex = 13;
            this.button_area_rivnobed.Text = "Обчислити";
            this.button_area_rivnobed.UseVisualStyleBackColor = true;
            this.button_area_rivnobed.Click += new System.EventHandler(this.button_area_rivnobed_Click);
            // 
            // button_perim_rivnobed
            // 
            this.button_perim_rivnobed.Location = new System.Drawing.Point(987, 420);
            this.button_perim_rivnobed.Name = "button_perim_rivnobed";
            this.button_perim_rivnobed.Size = new System.Drawing.Size(102, 35);
            this.button_perim_rivnobed.TabIndex = 16;
            this.button_perim_rivnobed.Text = "Обчислити";
            this.button_perim_rivnobed.UseVisualStyleBackColor = true;
            this.button_perim_rivnobed.Click += new System.EventHandler(this.button_perim_rivnobed_Click);
            // 
            // button_perim_rivn
            // 
            this.button_perim_rivn.Location = new System.Drawing.Point(642, 418);
            this.button_perim_rivn.Name = "button_perim_rivn";
            this.button_perim_rivn.Size = new System.Drawing.Size(102, 35);
            this.button_perim_rivn.TabIndex = 15;
            this.button_perim_rivn.Text = "Обчислити";
            this.button_perim_rivn.UseVisualStyleBackColor = true;
            this.button_perim_rivn.Click += new System.EventHandler(this.button_perim_rivn_Click);
            // 
            // button_perim_priam
            // 
            this.button_perim_priam.Location = new System.Drawing.Point(208, 419);
            this.button_perim_priam.Name = "button_perim_priam";
            this.button_perim_priam.Size = new System.Drawing.Size(102, 35);
            this.button_perim_priam.TabIndex = 14;
            this.button_perim_priam.Text = "Обчислити";
            this.button_perim_priam.UseVisualStyleBackColor = true;
            this.button_perim_priam.Click += new System.EventHandler(this.button_perim_priam_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 361);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(102, 36);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(518, 361);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(102, 36);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(865, 361);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(102, 36);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(865, 416);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(102, 36);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(518, 418);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(102, 36);
            this.textBox5.TabIndex = 21;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(84, 419);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(102, 36);
            this.textBox6.TabIndex = 20;
            // 
            // textBox_priam_a
            // 
            this.textBox_priam_a.Location = new System.Drawing.Point(88, 239);
            this.textBox_priam_a.Multiline = true;
            this.textBox_priam_a.Name = "textBox_priam_a";
            this.textBox_priam_a.Size = new System.Drawing.Size(65, 26);
            this.textBox_priam_a.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "a = ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "b = ";
            // 
            // textBox_priam_b
            // 
            this.textBox_priam_b.Location = new System.Drawing.Point(208, 239);
            this.textBox_priam_b.Multiline = true;
            this.textBox_priam_b.Name = "textBox_priam_b";
            this.textBox_priam_b.Size = new System.Drawing.Size(65, 26);
            this.textBox_priam_b.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(277, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = " ∠° = ";
            // 
            // textBox_priam_angle
            // 
            this.textBox_priam_angle.Location = new System.Drawing.Point(325, 239);
            this.textBox_priam_angle.Multiline = true;
            this.textBox_priam_angle.Name = "textBox_priam_angle";
            this.textBox_priam_angle.ReadOnly = true;
            this.textBox_priam_angle.Size = new System.Drawing.Size(65, 26);
            this.textBox_priam_angle.TabIndex = 27;
            this.textBox_priam_angle.Text = "90";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(586, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = " ∠° = ";
            // 
            // textBox_rivn_angle
            // 
            this.textBox_rivn_angle.Location = new System.Drawing.Point(642, 242);
            this.textBox_rivn_angle.Multiline = true;
            this.textBox_rivn_angle.Name = "textBox_rivn_angle";
            this.textBox_rivn_angle.ReadOnly = true;
            this.textBox_rivn_angle.Size = new System.Drawing.Size(65, 26);
            this.textBox_rivn_angle.TabIndex = 33;
            this.textBox_rivn_angle.Text = "60";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(472, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "a = ";
            // 
            // textBox_rivn_a
            // 
            this.textBox_rivn_a.Location = new System.Drawing.Point(518, 239);
            this.textBox_rivn_a.Multiline = true;
            this.textBox_rivn_a.Name = "textBox_rivn_a";
            this.textBox_rivn_a.Size = new System.Drawing.Size(65, 26);
            this.textBox_rivn_a.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1058, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 40;
            this.label16.Text = " ∠° = ";
            // 
            // textBox_rivnobed_angle
            // 
            this.textBox_rivnobed_angle.Location = new System.Drawing.Point(1106, 242);
            this.textBox_rivnobed_angle.Multiline = true;
            this.textBox_rivnobed_angle.Name = "textBox_rivnobed_angle";
            this.textBox_rivnobed_angle.Size = new System.Drawing.Size(65, 26);
            this.textBox_rivnobed_angle.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(949, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 17);
            this.label17.TabIndex = 38;
            this.label17.Text = "b = ";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(987, 242);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(65, 26);
            this.textBox14.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(827, 245);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 17);
            this.label18.TabIndex = 36;
            this.label18.Text = "a = ";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(865, 242);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(65, 26);
            this.textBox15.TabIndex = 35;
            // 
            // but_clear_1
            // 
            this.but_clear_1.Location = new System.Drawing.Point(208, 279);
            this.but_clear_1.Name = "but_clear_1";
            this.but_clear_1.Size = new System.Drawing.Size(80, 56);
            this.but_clear_1.TabIndex = 41;
            this.but_clear_1.Text = "Очистити поля";
            this.but_clear_1.UseVisualStyleBackColor = true;
            this.but_clear_1.Click += new System.EventHandler(this.but_clear_1_Click);
            // 
            // button_clear_2
            // 
            this.button_clear_2.Location = new System.Drawing.Point(642, 279);
            this.button_clear_2.Name = "button_clear_2";
            this.button_clear_2.Size = new System.Drawing.Size(80, 56);
            this.button_clear_2.TabIndex = 42;
            this.button_clear_2.Text = "Очистити поля";
            this.button_clear_2.UseVisualStyleBackColor = true;
            this.button_clear_2.Click += new System.EventHandler(this.button_clear_2_Click);
            // 
            // button_clear_3
            // 
            this.button_clear_3.Location = new System.Drawing.Point(987, 279);
            this.button_clear_3.Name = "button_clear_3";
            this.button_clear_3.Size = new System.Drawing.Size(80, 56);
            this.button_clear_3.TabIndex = 43;
            this.button_clear_3.Text = "Очистити поля";
            this.button_clear_3.UseVisualStyleBackColor = true;
            this.button_clear_3.Click += new System.EventHandler(this.button_clear_3_Click);
            // 
            // but_gen_1
            // 
            this.but_gen_1.Location = new System.Drawing.Point(84, 279);
            this.but_gen_1.Name = "but_gen_1";
            this.but_gen_1.Size = new System.Drawing.Size(110, 56);
            this.but_gen_1.TabIndex = 44;
            this.but_gen_1.Text = "Згенерувати сторони";
            this.but_gen_1.UseVisualStyleBackColor = true;
            this.but_gen_1.Click += new System.EventHandler(this.but_gen_1_Click);
            // 
            // but_gen_2
            // 
            this.but_gen_2.Location = new System.Drawing.Point(518, 279);
            this.but_gen_2.Name = "but_gen_2";
            this.but_gen_2.Size = new System.Drawing.Size(110, 56);
            this.but_gen_2.TabIndex = 45;
            this.but_gen_2.Text = "Згенерувати сторони";
            this.but_gen_2.UseVisualStyleBackColor = true;
            this.but_gen_2.Click += new System.EventHandler(this.but_gen_2_Click);
            // 
            // but_gen_3
            // 
            this.but_gen_3.Location = new System.Drawing.Point(865, 279);
            this.but_gen_3.Name = "but_gen_3";
            this.but_gen_3.Size = new System.Drawing.Size(110, 56);
            this.but_gen_3.TabIndex = 46;
            this.but_gen_3.Text = "Згенерувати сторони";
            this.but_gen_3.UseVisualStyleBackColor = true;
            this.but_gen_3.Click += new System.EventHandler(this.but_gen_3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(518, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 24);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // but_upload_priam
            // 
            this.but_upload_priam.Location = new System.Drawing.Point(427, 13);
            this.but_upload_priam.Name = "but_upload_priam";
            this.but_upload_priam.Size = new System.Drawing.Size(75, 68);
            this.but_upload_priam.TabIndex = 48;
            this.but_upload_priam.Text = "Завантажити до файлу";
            this.but_upload_priam.UseVisualStyleBackColor = true;
            this.but_upload_priam.Click += new System.EventHandler(this.but_upload_priam_Click);
            // 
            // but_downoload_priam
            // 
            this.but_downoload_priam.Location = new System.Drawing.Point(726, 13);
            this.but_downoload_priam.Name = "but_downoload_priam";
            this.but_downoload_priam.Size = new System.Drawing.Size(75, 68);
            this.but_downoload_priam.TabIndex = 49;
            this.but_downoload_priam.Text = "Вигрузити із файлу";
            this.but_downoload_priam.UseVisualStyleBackColor = true;
            this.but_downoload_priam.Click += new System.EventHandler(this.but_downoload_priam_Click);
            // 
            // but_add_priam
            // 
            this.but_add_priam.Location = new System.Drawing.Point(208, 173);
            this.but_add_priam.Name = "but_add_priam";
            this.but_add_priam.Size = new System.Drawing.Size(102, 56);
            this.but_add_priam.TabIndex = 50;
            this.but_add_priam.Text = "Додати до списку";
            this.but_add_priam.UseVisualStyleBackColor = true;
            this.but_add_priam.Click += new System.EventHandler(this.but_add_priam_Click);
            // 
            // but_save_priam
            // 
            this.but_save_priam.Location = new System.Drawing.Point(117, 173);
            this.but_save_priam.Name = "but_save_priam";
            this.but_save_priam.Size = new System.Drawing.Size(77, 56);
            this.but_save_priam.TabIndex = 53;
            this.but_save_priam.Text = "Зберегти зміни";
            this.but_save_priam.UseVisualStyleBackColor = true;
            this.but_save_priam.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_save_rivn
            // 
            this.but_save_rivn.Location = new System.Drawing.Point(530, 173);
            this.but_save_rivn.Name = "but_save_rivn";
            this.but_save_rivn.Size = new System.Drawing.Size(77, 56);
            this.but_save_rivn.TabIndex = 55;
            this.but_save_rivn.Text = "Зберегти зміни";
            this.but_save_rivn.UseVisualStyleBackColor = true;
            this.but_save_rivn.Click += new System.EventHandler(this.but_save_rivn_Click);
            // 
            // but_add_rivn
            // 
            this.but_add_rivn.Location = new System.Drawing.Point(621, 173);
            this.but_add_rivn.Name = "but_add_rivn";
            this.but_add_rivn.Size = new System.Drawing.Size(102, 56);
            this.but_add_rivn.TabIndex = 54;
            this.but_add_rivn.Text = "Додати до списку";
            this.but_add_rivn.UseVisualStyleBackColor = true;
            this.but_add_rivn.Click += new System.EventHandler(this.but_add_rivn_Click);
            // 
            // but_save_rivnobed
            // 
            this.but_save_rivnobed.Location = new System.Drawing.Point(896, 173);
            this.but_save_rivnobed.Name = "but_save_rivnobed";
            this.but_save_rivnobed.Size = new System.Drawing.Size(77, 56);
            this.but_save_rivnobed.TabIndex = 57;
            this.but_save_rivnobed.Text = "Зберегти зміни";
            this.but_save_rivnobed.UseVisualStyleBackColor = true;
            this.but_save_rivnobed.Click += new System.EventHandler(this.but_save_rivnobed_Click);
            // 
            // but_add_rivnobed
            // 
            this.but_add_rivnobed.Location = new System.Drawing.Point(987, 173);
            this.but_add_rivnobed.Name = "but_add_rivnobed";
            this.but_add_rivnobed.Size = new System.Drawing.Size(102, 56);
            this.but_add_rivnobed.TabIndex = 56;
            this.but_add_rivnobed.Text = "Додати до списку";
            this.but_add_rivnobed.UseVisualStyleBackColor = true;
            this.but_add_rivnobed.Click += new System.EventHandler(this.but_add_rivnobed_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 748);
            this.Controls.Add(this.but_save_rivnobed);
            this.Controls.Add(this.but_add_rivnobed);
            this.Controls.Add(this.but_save_rivn);
            this.Controls.Add(this.but_add_rivn);
            this.Controls.Add(this.but_save_priam);
            this.Controls.Add(this.but_add_priam);
            this.Controls.Add(this.but_downoload_priam);
            this.Controls.Add(this.but_upload_priam);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.but_gen_3);
            this.Controls.Add(this.but_gen_2);
            this.Controls.Add(this.but_gen_1);
            this.Controls.Add(this.button_clear_3);
            this.Controls.Add(this.button_clear_2);
            this.Controls.Add(this.but_clear_1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox_rivnobed_angle);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_rivn_angle);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox_rivn_a);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_priam_angle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_priam_b);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_priam_a);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_perim_rivnobed);
            this.Controls.Add(this.button_perim_rivn);
            this.Controls.Add(this.button_perim_priam);
            this.Controls.Add(this.button_area_rivnobed);
            this.Controls.Add(this.button_area_rivn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_area_priam);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_area_priam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_area_rivn;
        private System.Windows.Forms.Button button_area_rivnobed;
        private System.Windows.Forms.Button button_perim_rivnobed;
        private System.Windows.Forms.Button button_perim_rivn;
        private System.Windows.Forms.Button button_perim_priam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox_priam_a;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_priam_b;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_priam_angle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_rivn_angle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_rivn_a;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_rivnobed_angle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Button but_clear_1;
        private System.Windows.Forms.Button button_clear_2;
        private System.Windows.Forms.Button button_clear_3;
        private System.Windows.Forms.Button but_gen_1;
        private System.Windows.Forms.Button but_gen_2;
        private System.Windows.Forms.Button but_gen_3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button but_upload_priam;
        private System.Windows.Forms.Button but_downoload_priam;
        private System.Windows.Forms.Button but_add_priam;
        private System.Windows.Forms.Button but_save_priam;
        private System.Windows.Forms.Button but_save_rivn;
        private System.Windows.Forms.Button but_add_rivn;
        private System.Windows.Forms.Button but_save_rivnobed;
        private System.Windows.Forms.Button but_add_rivnobed;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

