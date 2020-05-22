using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WorldSkills_2020
{
    public partial class MainForm : Form
    {
        public static string CS = @"Data Source=АНТОН-ПК\fiery;Initial Catalog=DB_Sewing_Factory;Integrated Security=True";

        public static int GP = 0;
        public static string Logname;
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            textBox2.PasswordChar = '•';
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Entry_Click(object sender, EventArgs e)
        {
            string mySelectQuery = "SELECT Роль FROM dbo.Пользователь WHERE [Логин] = '" + textBox1.Text + "'and [Пароль]='" + textBox2.Text + "'";
            SqlConnection ThisConnection = new SqlConnection(MainForm.CS);
            ThisConnection.Open();
            SqlCommand thisCommand = ThisConnection.CreateCommand();
            thisCommand.CommandText = "SELECT Роль FROM dbo.Пользователь WHERE Логин = '" + textBox1.Text + "'and Пароль ='" + textBox2.Text + "'";
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            string res = string.Empty;
            while (thisReader.Read())
            {
                res += thisReader["Роль"];
            }
            thisReader.Close();
            ThisConnection.Close();

            switch (res)
            {
                case "Сlient":
                    Client CL = new Client();
                    CL.Show();
                    Logname = textBox1.Text;
                    this.Visible = false;
                    break;
                case "Storekeeper":
                    Storekeeper SK = new Storekeeper();
                    SK.Show();
                    Logname = textBox1.Text;
                    this.Visible = false;
                    break;
                case "Director":
                    Director Dr = new Director();
                    Dr.Show();
                    Logname = textBox1.Text;
                    this.Visible = false;
                    break;
                case "Manager":
                    Manager Mn = new Manager();
                    Mn.Show();
                    Logname = textBox1.Text;
                    this.Visible = false;
                    break;
                default:
                    MessageBox.Show("Пользователь не найден");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form AF = new Reg();
            AF.Show();
        }
    }
}
