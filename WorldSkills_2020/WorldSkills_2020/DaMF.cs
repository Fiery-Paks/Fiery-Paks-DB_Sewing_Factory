using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WorldSkills_2020
{
    public partial class DaMF : Form
    {
        public DaMF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MainForm.GP == 1)
            {
                Form Dr = new Director();
                Dr.Show();
                this.Close();
            }
            else if (MainForm.GP == 2)
            {
                Form Mn = new Manager();
                Mn.Show();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void STF_Load(object sender, EventArgs e)
        {
            string mySelectQuery = "SELECT * FROM dbo.Изделие";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, MainForm.CS))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
    }
}
