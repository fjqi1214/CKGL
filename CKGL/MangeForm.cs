using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using BLL;
using DAL;
using Interface;

namespace CKGL
{
    public partial class MangeForm : Form
    {
        UserService userS;
        Form parentForm;
        ISplitePage SplitePager;
        public MangeForm(UserService us, Form parentForm)
        {

            InitializeComponent();
            this.userS = us;
            this.parentForm = parentForm;
            SetStorageLocationTab();
            this.dgvSL.DataSource = this.bS;
            this.bN.BindingSource = this.bS;



        }

        public CKGLContext Context { get; set; }

        private void cExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MangeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentForm.Show();
        }

        private void mangeTab_Selected(object sender, TabControlEventArgs e)
        {
            //MessageBox.Show(e.TabPageIndex.ToString());
            switch (e.TabPageIndex)
            {
                case 0:
                    InitialSpliteTool();
                    SplitePager = new SplitePage<StorageLocationTable>();
                    break;
                case 1:

                    break;
                case 2:

                    break;

                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
        }


        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.bS.DataSource = ((SplitePage<StorageLocationTable>)SplitePager).MoveNextPage();
        }


        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            this.bS.DataSource = ((SplitePage<StorageLocationTable>)SplitePager).MoveFirstPage();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.bS.DataSource = ((SplitePage<StorageLocationTable>)SplitePager).MovePreviousPage();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            this.bS.DataSource = ((SplitePage<StorageLocationTable>)SplitePager).MoveLastPage();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 进入库位管理标签页
        /// </summary>
        private void SetStorageLocationTab()
        {
            InitialSpliteTool();
            SplitePager = new SplitePage<StorageLocationModel>();
            ((SplitePage<StorageLocationModel>)SplitePager).SplitePager = new StorageLocationCollection();
            this.bS.DataSource = ((SplitePage<StorageLocationModel>)SplitePager).MoveFirstPage();
        }

        /// <summary>
        /// 进入库存管理标签页
        /// </summary>
        private void SetProductTab()
        {
            InitialSpliteTool();

        }

        /// <summary>
        /// 进入入库管理标签页
        /// </summary>
        private void SetImportStorageTab()
        {

        }

        /// <summary>
        /// 进入出库管理标签页
        /// </summary>
        private void SetExportStorageTab()
        {

        }

        /// <summary>
        /// 进入盘点管理标签页
        /// </summary>
        private void SetCheckRecordTab()
        {

        }

        /// <summary>
        /// 进入厂家管理标签页
        /// </summary>
        private void SetManufacturerTab()
        {

        }


        private void InitialSpliteTool()
        {
            cbPageItemNum.SelectedIndex = 0;
        }

      
    }
}
