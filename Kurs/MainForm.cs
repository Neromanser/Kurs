using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();
            label9.Text = "Приветствие";

            label16.Hide();
            label17.Hide();
            label18.Hide();
            label6.Hide();
            label7.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            label20.Hide();
            label19.Hide();
              

            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();

            button1.Hide();
            button2.Hide();

            label5.Text = nulltime.ToString();
  
        }
        public static double sum = 0;
        public static double total = 0;
        public static int a;
        public static double o;
        public static double j;
        public static double l;
        public static double nulltime = 0;
        private void label10_Click(object sender, EventArgs e)
        {
            hide.PerformClick();  // хыы прячем все элементы

            label9.Text = "Добавление расхода";
            label9.Location = new System.Drawing.Point(250, 0);

            //label13.Hide();


            label16.Show();
            label16.Location = new System.Drawing.Point(213, 105);
            label17.Show();
            label17.Location = new System.Drawing.Point(334, 105);
            label18.Show();
            label18.Location = new System.Drawing.Point(455, 105);

            textBox1.Show();
            textBox1.Location = new System.Drawing.Point(182, 124);
            textBox2.Show();
            textBox2.Location = new System.Drawing.Point(305, 124);
            textBox3.Show();
            textBox3.Location = new System.Drawing.Point(422, 124);

            button1.Show();
            button1.Location = new System.Drawing.Point(318, 50);  

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Red;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Black;
        }

        private void label19_Click(object sender, EventArgs e)
        {

            hide.PerformClick();  // хыы прячем все элементы
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            listBox1.Items.Add(string.Concat("ФИО: ", textBox1.Text, " Сумма: ", textBox2.Text, " Дата:", textBox3.Text));
            listBox3.Items.Add(textBox2.Text);
            
            foreach (string s in listBox3.Items)
            {
                total += double.Parse(s.ToString());
                label14.Text = total.ToString();

                
            }
            label14.Text = total.ToString();
            
            foreach (string s in listBox3.Items)
            {
                total += double.Parse(s.ToString());
                label7.Text = total.ToString();
                
                total = 0;
                
            }
            
            o = Convert.ToInt32(label5.Text);
            j = Convert.ToInt32(label7.Text);
            l = o - j;
            label5.Text = l.ToString();
            total = 0;
        }

                private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox4.Text);

            foreach (string s in listBox2.Items)
            {
                sum += double.Parse(s.ToString());
                
            }
            label20.Text = sum.ToString();
            label5.Text = sum.ToString();
            sum = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

            label9.Text = "Доходы";
            label9.Location = new System.Drawing.Point(308, 7);

            hide.PerformClick();


            label6.Show();
            label6.Location = new System.Drawing.Point(316, 66);

            textBox4.Show();
            textBox4.Location = new System.Drawing.Point(301, 95);

            button2.Show();
            button2.Location = new System.Drawing.Point(312, 121);


        }

        private void hide_Click(object sender, EventArgs e)
        {
            label16.Hide();
            label17.Hide();
            label18.Hide();
            label6.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            label20.Hide();
            label22.Hide();
            label23.Hide();
            label24.Hide();
            label25.Hide();
            label26.Hide();
            

            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();

            button1.Hide();
            button2.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
                if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
                else
            {
                MessageBox.Show("Выберите элемент");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            hide.PerformClick();

            label13.Show();
            label14.Show();
            label15.Show();
            label20.Show();
            label9.Text = "Доход/расход за весь период";
            label9.Location = new System.Drawing.Point(210, 7);
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }
        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Red;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Black;
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            label11.ForeColor = Color.Red;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.ForeColor = Color.Black;
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label12.ForeColor = Color.Red;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.ForeColor = Color.Black;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        Point move;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)                                          // движение окна
            {
                this.Left += e.X - move.X;
                this.Top += e.Y - move.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = new Point(e.X, e.Y);
        }
    }
}
