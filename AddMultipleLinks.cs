using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tracker
{
    public partial class AddMultipleLinks : Form
    {
        private List<String> URLS = new List<string>();
        private List<String> Titles = new List<string>();

        public AddMultipleLinks()
        {
            InitializeComponent();
        }

        public int getLinesCount()
        {
            if(URLBox.Lines.Length == TitleBox.Lines.Length)
            {
                return URLBox.Lines.Length;
            }
            else
            {
                return -1; // This functions like a sentinel value.
            }
        }

        public String getURLAt(int i)
        {
            return URLBox.Lines[i];
        }

        public String getTitleAt(int i)
        {
            return TitleBox.Lines[i];
        }

        public void trimBoxes()
        {
            foreach(String line in URLBox.Lines)
            {
                line.Trim();
            }

            foreach(String line in TitleBox.Lines)
            {
                line.Trim();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            trimBoxes();
            if(URLBox.Lines.Length == TitleBox.Lines.Length)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }           
        }
    }
}
