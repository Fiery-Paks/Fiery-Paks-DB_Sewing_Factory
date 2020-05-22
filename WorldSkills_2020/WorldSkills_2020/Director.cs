using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkills_2020
{
    public partial class Director : Form
    {
        public Director()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm.GP = 1;
            Form KI = new DaMF();
            KI.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form MF = new MainForm();
            MF.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
