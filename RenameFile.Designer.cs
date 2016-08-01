namespace Tracker
{
    partial class RenameFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInvalidWarning = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelOldName = new System.Windows.Forms.Label();
            this.textBoxOldName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInvalidWarning
            // 
            this.labelInvalidWarning.AutoSize = true;
            this.labelInvalidWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelInvalidWarning.ForeColor = System.Drawing.Color.IndianRed;
            this.labelInvalidWarning.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelInvalidWarning.Location = new System.Drawing.Point(144, 133);
            this.labelInvalidWarning.Name = "labelInvalidWarning";
            this.labelInvalidWarning.Size = new System.Drawing.Size(81, 13);
            this.labelInvalidWarning.TabIndex = 7;
            this.labelInvalidWarning.Text = "Invalid Name";
            this.labelInvalidWarning.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(368, 128);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOk.Location = new System.Drawing.Point(240, 128);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(122, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNewName);
            this.groupBox1.Controls.Add(this.labelTitle);
            this.groupBox1.Controls.Add(this.labelOldName);
            this.groupBox1.Controls.Add(this.textBoxOldName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter a New File Name";
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxNewName.Location = new System.Drawing.Point(10, 75);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(462, 20);
            this.textBoxNewName.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTitle.Location = new System.Drawing.Point(7, 59);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(181, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "New Name (Filename and Extension)";
            // 
            // labelOldName
            // 
            this.labelOldName.AutoSize = true;
            this.labelOldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelOldName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelOldName.Location = new System.Drawing.Point(7, 20);
            this.labelOldName.Name = "labelOldName";
            this.labelOldName.Size = new System.Drawing.Size(54, 13);
            this.labelOldName.TabIndex = 1;
            this.labelOldName.Text = "Old Name";
            // 
            // textBoxOldName
            // 
            this.textBoxOldName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOldName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxOldName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxOldName.Location = new System.Drawing.Point(10, 36);
            this.textBoxOldName.Name = "textBoxOldName";
            this.textBoxOldName.Size = new System.Drawing.Size(462, 20);
            this.textBoxOldName.TabIndex = 0;
            // 
            // RenameFile
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(505, 157);
            this.Controls.Add(this.labelInvalidWarning);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOk);
            this.Name = "RenameFile";
            this.Text = "Rename a File";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInvalidWarning;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelOldName;
        private System.Windows.Forms.TextBox textBoxOldName;

    }
}