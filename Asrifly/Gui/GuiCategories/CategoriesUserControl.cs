using Asrfly.Gui.GuiHome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiCategories
{
    public partial class CategoriesUserControl : UserControl
    {
        private static CategoriesUserControl _CategoriesUserControl;
        public CategoriesUserControl()
        {
            InitializeComponent();
        }
        public static CategoriesUserControl Instance1()
        {
            return _CategoriesUserControl ?? (new CategoriesUserControl());
        }

        #region Events
        private void CategoriesUserControl_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
    }
}
