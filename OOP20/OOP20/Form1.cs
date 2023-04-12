using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "a =";
            label1.Text = "Заповніть три поля";
            label3.Text = "b =";
            label4.Text = "c =";
            button1.Text= "Ok";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;

            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b) && double.TryParse(textBox3.Text, out c))
            {
                try
                {
                    double delta = b * b - 4 * a * c;
                    if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
                    {
                        throw new Exception("Пусті поля!");
                    }
                    else if (delta < 0)
                    {
                        throw new Exception("Рівняння не має дійсних коренів.");
                    }
                    else if (a == 0)
                    {
                        throw new Exception("змінна a не може дорівнювати нулю");
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        label1.Text = string.Format("x1 = {0:N2};  x2 = {1:N2}.", x1, x2);
                    }
                }
                catch (Exception ex)
                {
                    label1.Text = string.Format("Сталася помилка: {0}", ex.Message);
                }
            }
            else if ((textBox1.Text == "") || (textBox2.Text == "") && (textBox3.Text == ""))
            {
                label1.Text = "Пусті поля!";
            }
            else
            {
                label1.Text = "Можливо ви поставили забагато ком";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                // крапку замінемо проб
                e.KeyChar = ',';
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    textBox1.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }// Захист для поля

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                // крапку замінемо проб
                e.KeyChar = ',';
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    textBox2.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }// Захист для поля

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                // крапку замінемо проб
                e.KeyChar = ',';
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    textBox3.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }// Захист для поля
    }
    }
