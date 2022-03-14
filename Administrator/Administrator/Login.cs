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
    public partial class Login : Form
    {
        //判断账号密码是否匹配
        bool isLogin = true;//测试阶段默认为真
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                Form f1 = new Main(this);//创建一个主窗体对象
                f1.Visible = true;  //设置可见性为真
                this.Visible = false;//隐藏登陆窗口
            }
        }
    }
}
