using System;
using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            

            loginus.Text = "Enter your login";                                        // Вводит текст в ячейки
            loginus.ForeColor = Color.Gray;

            passus.Text = "Enter password";
            passus.ForeColor = Color.Gray;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void close1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close1_MouseEnter(object sender, EventArgs e)
        {
            close1.ForeColor = Color.Red;
        }

        private void close1_MouseLeave(object sender, EventArgs e)
        {
            close1.ForeColor = Color.Black;
        }
        Point move;
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - move.X;
                this.Top += e.Y - move.Y;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            move = new Point(e.X, e.Y);
        }
       
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginus.Text;
            String pussUser = passus.Text;

            db db = new db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP ",db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginus.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passus.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
                
            else
                MessageBox.Show("Incorrect login or password");

            
          
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - move.X;
                this.Top += e.Y - move.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = new Point(e.X, e.Y);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void registerform_MouseEnter(object sender, EventArgs e)
        {
            registerform.ForeColor = Color.Red;
        }

        private void registerform_MouseLeave(object sender, EventArgs e)
        {
            registerform.ForeColor = Color.Black;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - move.X;
                this.Top += e.Y - move.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            move = new Point(e.X, e.Y);
        }

        private void loginus_Enter(object sender, EventArgs e)
        {
            if (loginus.Text == "Enter your login")                                          // серый текст
                loginus.Text = "";
            loginus.ForeColor = Color.Black;
        }

        private void loginus_Leave(object sender, EventArgs e)
        {
            if (loginus.Text == "")
            {
                loginus.Text = "Enter your login";
                loginus.ForeColor = Color.Gray;
            }
        }

        private void passus_Enter(object sender, EventArgs e)
        {
            if (passus.Text == "Enter password")                                          // серый текст
                passus.Text = "";
            passus.ForeColor = Color.Black;
        }

        private void passus_Leave(object sender, EventArgs e)
        {
            if (passus.Text == "")
            {
                passus.Text = "Enter password";
                passus.ForeColor = Color.Gray;
            }
        }

        private void loginus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
