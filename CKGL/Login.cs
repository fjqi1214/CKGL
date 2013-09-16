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
       
        MangeForm manageForm;

        private CKGLContext db;
        public Login()
        {
            InitializeComponent();
            CKGLContext db = new CKGLContext();
            //db.Users.Add(new User { Auth = AuthLevel.Common, UserName = "fdff" });

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserService us = new UserService();
            us.UserValidate = new CKGLDAL<User>(this.db);
            var name = txtName.Text;
            var pwd = txtPwd.Text;
            bool result = us.Login(name, pwd);

            if (!result)
            {
                //用户登录失败
                ShowPrompt("用户名或密码错误！");
            }
            else
            { 
                //用户登录成功
                manageForm = new MangeForm(us, this);
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
