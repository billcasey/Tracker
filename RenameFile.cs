using System;
using System.Windows.Forms;

namespace Tracker
{
    public partial class RenameFile : Form
    {
        public String newName { get; set; }

        public RenameFile(String oldPath, String oldTitle)
        {
            InitializeComponent();
            labelOldName.Text = oldPath;
            textBoxOldName.Text = oldTitle;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //TODO add input validation to check and see if the new name is actually valid.
            //Ensure that the name is compatible with NTFS naming rules
            //https://msdn.microsoft.com/en-us/library/windows/desktop/aa365247(v=vs.85).aspx

            if(String.IsNullOrWhiteSpace(newName) || String.IsNullOrEmpty(newName))
            {
                labelInvalidWarning.Visible = true;
                //TODO add an event handler elsewhere so that when the user starts to edit the name the invalid warning goes away.
            }
            else
            {
                newName = textBoxNewName.Text; //TODO extract the path automatically and concatenate it.
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
