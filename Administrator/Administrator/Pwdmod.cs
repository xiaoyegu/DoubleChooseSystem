using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class Pwdmod : Form
    {
        Form f1 = null;
        public Pwdmod()
        {
            InitializeComponent();
        }
        public Pwdmod(Form fs)
        {
            InitializeComponent();
            f1 = fs;
        }
        private void Pwdmod_Load(object sender, EventArgs e)
        {

        }

        private void Pwdmod_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Visible = true;
        }
    }
}
