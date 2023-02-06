using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Asrifly;
using System.Windows.Forms;

namespace Asrfly.Code
{
    public class PageManeger
    {
        private readonly Main main;

        public PageManeger(Main main)
        {
            this.main = main;
        }
        public void LoadPage(UserControl PageUserControl)
        {
            //Load Old Page
            var oldPage = main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldPage != null)
            {
                main.panelContainer.Controls.Remove(oldPage); //Remove current page
                oldPage.Dispose();
            }

            //Load New Page
            PageUserControl.Dock= DockStyle.Fill;
            main.panelContainer.Controls.Add(PageUserControl);
        }
    }
}
