using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracker
{
    public partial class AddLink : Form
    {
        private String pageTitle;
        private String URL;

        public AddLink()
        {
            InitializeComponent();
        }

        public String getPageTitle()
        {
            return this.pageTitle;
        }

        public void setPageTitle(String pageTitle)
        {
            this.pageTitle = pageTitle;
        }

        public String getURL()
        {
            return this.URL;
        }

        public void setURL(String URL)
        {
            this.URL = URL;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(textBoxTitle.Text != String.Empty && textBoxURL.Text != String.Empty)
            {
                setPageTitle(textBoxTitle.Text);
                setURL(textBoxURL.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                //TODO add an event handler elsewhere so that edits made to the textbox take away the warning.
                labelInvalidWarning.Visible = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
