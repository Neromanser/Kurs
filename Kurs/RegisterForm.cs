using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Kurs
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            loginusreg.Text = "Enter your login";                                        // Вводит текст в ячейки
            loginusreg.ForeColor = Color.Gray;

            passusreg.Text = "Enter password";
            passusreg.ForeColor = Color.Gray;

            name.Text = "Enter your name";
            name.ForeColor = Color.Gray;

            surname.Text = "Enter your surname";
            surname.ForeColor = Color.Gray;

            
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void close1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void close1_MouseEnter(object sender, EventArgs e)
        {
            close1.ForeColor = Color.Red;
        }

        private void close1_MouseLeave(object sender, EventArgs e)
        {
            close1.ForeColor = Color.Black;
        }

        private void loginusreg_Enter(object sender, EventArgs e)
        {
            if (loginusreg.Text == "Enter your login")                                          // серый текст
                loginusreg.Text = "";
            loginusreg.ForeColor = Color.Black;
        }

        private void loginusreg_Leave(object sender, EventArgs e)
        {
            if (loginusreg.Text == "")
            {
                loginusreg.Text = "Enter your login";
                loginusreg.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (loginusreg.Text == "Enter your login")
                MessageBox.Show("Enter your login");

            
                if (checUser())
                    return;
            
            db db = new db();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)", db.getConnection());   // подключение к базе, заглушки + проверка

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginusreg.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passusreg.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Account created!");
            else
                MessageBox.Show("Error!");

            db.closeConnection();
        }


        public Boolean checUser()                                                     //проверка логина на индивидуальность
        {
         db db = new db();

        DataTable table = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

        MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());   //подключение к базе данных, выборка из нее и проверка на оригинальность 

        command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginusreg.Text;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("login is alredy");
            return true;
            }
            else
                return false;

        }

        private void sinin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            
        }

        private void passusreg_Enter(object sender, EventArgs e)
        {
            if (passusreg.Text == "Enter password")                                          // серый текст
                passusreg.Text = "";
            passusreg.ForeColor = Color.Black;
        }

        private void passusreg_Leave(object sender, EventArgs e)
        {
            if (passusreg.Text == "")
            {
                passusreg.Text = "Enter password";
                passusreg.ForeColor = Color.Gray;
            }
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Enter your name")                                          // серый текст
                name.Text = "";
            name.ForeColor = Color.Black;
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text = "Enter your name";
                name.ForeColor = Color.Gray;
            }
        }

        private void surname_Enter(object sender, EventArgs e)
        {
            if (surname.Text == "Enter your surname")                                          // серый текст
                surname.Text = "";
            surname.ForeColor = Color.Black;
        }

        private void surname_Leave(object sender, EventArgs e)
        {
            if (surname.Text == "")
            {
                surname.Text = "Enter your surname";
                surname.ForeColor = Color.Gray;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
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

        private void sinin_MouseEnter(object sender, EventArgs e)
        {
            sinin.ForeColor = Color.Red;
        }

        private void sinin_MouseLeave(object sender, EventArgs e)
        {
            sinin.ForeColor = Color.Black;
        }
    }
}
