using Asrfly.Gui.GuiCategories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiHome
{
    public partial class HomeUserControl1 : UserControl
    {
        private static HomeUserControl1 _HomeUserControl1;
        
        public HomeUserControl1()
        {
            InitializeComponent();
        }

        public static HomeUserControl1 Instance()
        {
            return _HomeUserControl1 ?? (new HomeUserControl1());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       
    }
}
