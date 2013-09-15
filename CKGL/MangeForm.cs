using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace CKGL
{
    public partial class MangeForm : Form
    {
        User user;
        Form parentForm;
        public MangeForm(User user,Form parentForm)
        {
           
            InitializeComponent();
            this.user = user;
            this.parentForm = parentForm;

        }

        private void cExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MangeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
