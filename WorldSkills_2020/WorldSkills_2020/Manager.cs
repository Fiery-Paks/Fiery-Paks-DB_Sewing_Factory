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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm.GP = 2;
            Form KI = new DaMF();
            KI.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form zak = new Zakaz();
            zak.Show();
            this.Close();
        }
    }
}
