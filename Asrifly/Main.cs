using Asrfly.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrifly
{
    public partial class Main : Form
    {
        private readonly PageManeger pageManeger;
        public Main()
        {
            InitializeComponent();
            pageManeger = new PageManeger(this);
            //Load Home Page
            //pageManeger.LoadPage(Asrfly.Gui.GuiHome.HomeUserControl1.Instance());

        }

        #region Events
        private void buttonHome_Click(object sender, EventArgs e)
        {
            pageManeger.LoadPage(Asrfly.Gui.GuiHome.HomeUserControl1.Instance());
        }
        #endregion

        private void buttonCatigories_Click(object sender, EventArgs e)
        {
            pageManeger.LoadPage(Asrfly.Gui.GuiCategories.CategoriesUserControl.Instance1());

        }
    }
}
