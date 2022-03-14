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
    }
}
