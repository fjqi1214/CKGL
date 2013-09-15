using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Model;
using BLL;

namespace CKGL
{
    public partial class Login : Form
    {
        CKGLContext db = new CKGLContext();
        MangeForm manageForm;
        public Login()
        {
            InitializeComponent();
            //CKGLContext db = new CKGLContext();
            //db.Users.Add(new User { Auth = AuthLevel.Common, UserName = "fdff" });

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLogin login = new UserLogin();
            login.UserValidate = new CKGLDAL();
            //用户输入的过滤
            var name = txtName.Text;
            var pwd = txtPwd.Text;
            User user = login.Login(name, pwd);
           
            if (user == null)
            {
                //用户登录失败
                ShowPrompt("用户名或密码错误！");
            }
            else
            { 
                //用户登录成功
                manageForm = new MangeForm(user,this);
                manageForm.Show();
                this.Hide();
                
            }
        }

        private void ShowPrompt(string message)
        {
            MessageBox.Show(message, "提示");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
