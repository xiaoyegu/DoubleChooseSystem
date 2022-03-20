using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Main : Form
    {
        //登陆窗口
        Form Login;
        public Main()
        {
            InitializeComponent();
        }
        public Main(Form f1)
        {
            InitializeComponent();
            Login = f1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Grad_Des_que f = new Grad_Des_que();
            f.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Grad_Des_que f2 = new Grad_Des_que();
            f2.ShowDialog();
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
        }
    }
}
