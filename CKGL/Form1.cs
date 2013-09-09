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

namespace CKGL
{
    public partial class Form1 : Form
    {
        CKGLContext db = new CKGLContext();
        public Form1()
        {
            InitializeComponent();
            CKGLContext db = new CKGLContext();
            db.Users.Add(new User { Auth = AuthLevel.Common, UserName = "fdff" });

        }
    }
}
