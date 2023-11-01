namespace PdfReader.Win
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
            txtPdfFilePath = new System.Windows.Forms.TextBox();
            btnSelectPdf = new System.Windows.Forms.Button();
            panel = new System.Windows.Forms.Panel();
            grpWorkingExperience = new System.Windows.Forms.GroupBox();
            txtOthers = new System.Windows.Forms.TextBox();
            lblOthers = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            lblDescription = new System.Windows.Forms.Label();
            txtPeriod = new System.Windows.Forms.TextBox();
            lblPeriod = new System.Windows.Forms.Label();
            txtOldTitle = new System.Windows.Forms.TextBox();
            lblOldTitle = new System.Windows.Forms.Label();
            txtOldCompany = new System.Windows.Forms.TextBox();
            lblOldCompany = new System.Windows.Forms.Label();
            grpContact = new System.Windows.Forms.GroupBox();
            txtLinkedIn = new System.Windows.Forms.TextBox();
            lblLinkedIn = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            lblPhone = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            lblAddress = new System.Windows.Forms.Label();
            txtTopSkills = new System.Windows.Forms.TextBox();
            lblTopSkills = new System.Windows.Forms.Label();
            txtWorkingPlace = new System.Windows.Forms.TextBox();
            lblWorkingPlace = new System.Windows.Forms.Label();
            txtCompany = new System.Windows.Forms.TextBox();
            lblCompany = new System.Windows.Forms.Label();
            txtTitle = new System.Windows.Forms.TextBox();
            lblTitle = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            lblFullName = new System.Windows.Forms.Label();
            panel.SuspendLayout();
            grpWorkingExperience.SuspendLayout();
            grpContact.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            // 
            // txtPdfFilePath
            // 
            txtPdfFilePath.Location = new System.Drawing.Point(12, 12);
            txtPdfFilePath.Name = "txtPdfFilePath";
            txtPdfFilePath.ReadOnly = true;
            txtPdfFilePath.Size = new System.Drawing.Size(532, 27);
            txtPdfFilePath.TabIndex = 0;
            // 
            // btnSelectPdf
            // 
            btnSelectPdf.Location = new System.Drawing.Point(562, 10);
            btnSelectPdf.Name = "btnSelectPdf";
            btnSelectPdf.Size = new System.Drawing.Size(94, 29);
            btnSelectPdf.TabIndex = 1;
            btnSelectPdf.Text = "Select PDF";
            btnSelectPdf.UseVisualStyleBackColor = true;
            btnSelectPdf.Click += btnSelectPdf_Click;
            // 
            // panel
            // 
            panel.Controls.Add(grpWorkingExperience);
            panel.Controls.Add(grpContact);
            panel.Controls.Add(txtTopSkills);
            panel.Controls.Add(lblTopSkills);
            panel.Controls.Add(txtWorkingPlace);
            panel.Controls.Add(lblWorkingPlace);
            panel.Controls.Add(txtCompany);
            panel.Controls.Add(lblCompany);
            panel.Controls.Add(txtTitle);
            panel.Controls.Add(lblTitle);
            panel.Controls.Add(txtFullName);
            panel.Controls.Add(lblFullName);
            panel.Location = new System.Drawing.Point(12, 45);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(926, 492);
            panel.TabIndex = 2;
            // 
            // grpWorkingExperience
            // 
            grpWorkingExperience.Controls.Add(txtOthers);
            grpWorkingExperience.Controls.Add(lblOthers);
            grpWorkingExperience.Controls.Add(txtDescription);
            grpWorkingExperience.Controls.Add(lblDescription);
            grpWorkingExperience.Controls.Add(txtPeriod);
            grpWorkingExperience.Controls.Add(lblPeriod);
            grpWorkingExperience.Controls.Add(txtOldTitle);
            grpWorkingExperience.Controls.Add(lblOldTitle);
            grpWorkingExperience.Controls.Add(txtOldCompany);
            grpWorkingExperience.Controls.Add(lblOldCompany);
            grpWorkingExperience.Location = new System.Drawing.Point(13, 233);
            grpWorkingExperience.Name = "grpWorkingExperience";
            grpWorkingExperience.Size = new System.Drawing.Size(900, 248);
            grpWorkingExperience.TabIndex = 11;
            grpWorkingExperience.TabStop = false;
            grpWorkingExperience.Text = "Working Experience";
            // 
            // txtOthers
            // 
            txtOthers.Location = new System.Drawing.Point(524, 29);
            txtOthers.Multiline = true;
            txtOthers.Name = "txtOthers";
            txtOthers.ReadOnly = true;
            txtOthers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtOthers.Size = new System.Drawing.Size(365, 207);
            txtOthers.TabIndex = 11;
            // 
            // lblOthers
            // 
            lblOthers.AutoSize = true;
            lblOthers.Location = new System.Drawing.Point(446, 32);
            lblOthers.Name = "lblOthers";
            lblOthers.Size = new System.Drawing.Size(52, 20);
            lblOthers.TabIndex = 10;
            lblOthers.Text = "Others";
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(106, 128);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDescription.Size = new System.Drawing.Size(320, 108);
            txtDescription.TabIndex = 9;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(6, 131);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(85, 20);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description";
            // 
            // txtPeriod
            // 
            txtPeriod.Location = new System.Drawing.Point(106, 95);
            txtPeriod.Name = "txtPeriod";
            txtPeriod.ReadOnly = true;
            txtPeriod.Size = new System.Drawing.Size(320, 27);
            txtPeriod.TabIndex = 7;
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.Location = new System.Drawing.Point(6, 98);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new System.Drawing.Size(51, 20);
            lblPeriod.TabIndex = 6;
            lblPeriod.Text = "Period";
            // 
            // txtOldTitle
            // 
            txtOldTitle.Location = new System.Drawing.Point(106, 62);
            txtOldTitle.Name = "txtOldTitle";
            txtOldTitle.ReadOnly = true;
            txtOldTitle.Size = new System.Drawing.Size(320, 27);
            txtOldTitle.TabIndex = 5;
            // 
            // lblOldTitle
            // 
            lblOldTitle.AutoSize = true;
            lblOldTitle.Location = new System.Drawing.Point(6, 65);
            lblOldTitle.Name = "lblOldTitle";
            lblOldTitle.Size = new System.Drawing.Size(38, 20);
            lblOldTitle.TabIndex = 4;
            lblOldTitle.Text = "Title";
            // 
            // txtOldCompany
            // 
            txtOldCompany.Location = new System.Drawing.Point(106, 29);
            txtOldCompany.Name = "txtOldCompany";
            txtOldCompany.ReadOnly = true;
            txtOldCompany.Size = new System.Drawing.Size(320, 27);
            txtOldCompany.TabIndex = 3;
            // 
            // lblOldCompany
            // 
            lblOldCompany.AutoSize = true;
            lblOldCompany.Location = new System.Drawing.Point(6, 32);
            lblOldCompany.Name = "lblOldCompany";
            lblOldCompany.Size = new System.Drawing.Size(72, 20);
            lblOldCompany.TabIndex = 2;
            lblOldCompany.Text = "Company";
            // 
            // grpContact
            // 
            grpContact.Controls.Add(txtLinkedIn);
            grpContact.Controls.Add(lblLinkedIn);
            grpContact.Controls.Add(txtEmail);
            grpContact.Controls.Add(lblEmail);
            grpContact.Controls.Add(txtPhone);
            grpContact.Controls.Add(lblPhone);
            grpContact.Controls.Add(txtAddress);
            grpContact.Controls.Add(lblAddress);
            grpContact.Location = new System.Drawing.Point(550, 13);
            grpContact.Name = "grpContact";
            grpContact.Size = new System.Drawing.Size(363, 202);
            grpContact.TabIndex = 10;
            grpContact.TabStop = false;
            grpContact.Text = "Contact";
            // 
            // txtLinkedIn
            // 
            txtLinkedIn.Location = new System.Drawing.Point(82, 132);
            txtLinkedIn.Multiline = true;
            txtLinkedIn.Name = "txtLinkedIn";
            txtLinkedIn.ReadOnly = true;
            txtLinkedIn.Size = new System.Drawing.Size(270, 51);
            txtLinkedIn.TabIndex = 9;
            // 
            // lblLinkedIn
            // 
            lblLinkedIn.AutoSize = true;
            lblLinkedIn.Location = new System.Drawing.Point(6, 135);
            lblLinkedIn.Name = "lblLinkedIn";
            lblLinkedIn.Size = new System.Drawing.Size(64, 20);
            lblLinkedIn.TabIndex = 8;
            lblLinkedIn.Text = "LinkedIn";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(82, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new System.Drawing.Size(270, 27);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(6, 99);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(82, 66);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new System.Drawing.Size(270, 27);
            txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new System.Drawing.Point(6, 69);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(50, 20);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone";
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(82, 33);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new System.Drawing.Size(270, 27);
            txtAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new System.Drawing.Point(6, 36);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(62, 20);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address";
            // 
            // txtTopSkills
            // 
            txtTopSkills.Location = new System.Drawing.Point(129, 145);
            txtTopSkills.Multiline = true;
            txtTopSkills.Name = "txtTopSkills";
            txtTopSkills.ReadOnly = true;
            txtTopSkills.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtTopSkills.Size = new System.Drawing.Size(403, 70);
            txtTopSkills.TabIndex = 9;
            // 
            // lblTopSkills
            // 
            lblTopSkills.AutoSize = true;
            lblTopSkills.Location = new System.Drawing.Point(13, 148);
            lblTopSkills.Name = "lblTopSkills";
            lblTopSkills.Size = new System.Drawing.Size(69, 20);
            lblTopSkills.TabIndex = 8;
            lblTopSkills.Text = "Top skills";
            // 
            // txtWorkingPlace
            // 
            txtWorkingPlace.Location = new System.Drawing.Point(129, 112);
            txtWorkingPlace.Name = "txtWorkingPlace";
            txtWorkingPlace.ReadOnly = true;
            txtWorkingPlace.Size = new System.Drawing.Size(403, 27);
            txtWorkingPlace.TabIndex = 7;
            // 
            // lblWorkingPlace
            // 
            lblWorkingPlace.AutoSize = true;
            lblWorkingPlace.Location = new System.Drawing.Point(13, 115);
            lblWorkingPlace.Name = "lblWorkingPlace";
            lblWorkingPlace.Size = new System.Drawing.Size(104, 20);
            lblWorkingPlace.TabIndex = 6;
            lblWorkingPlace.Text = "Working place";
            // 
            // txtCompany
            // 
            txtCompany.Location = new System.Drawing.Point(129, 79);
            txtCompany.Name = "txtCompany";
            txtCompany.ReadOnly = true;
            txtCompany.Size = new System.Drawing.Size(403, 27);
            txtCompany.TabIndex = 5;
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new System.Drawing.Point(13, 82);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new System.Drawing.Size(72, 20);
            lblCompany.TabIndex = 4;
            lblCompany.Text = "Company";
            // 
            // txtTitle
            // 
            txtTitle.Location = new System.Drawing.Point(129, 46);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new System.Drawing.Size(403, 27);
            txtTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(13, 49);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(38, 20);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title";
            // 
            // txtFullName
            // 
            txtFullName.Location = new System.Drawing.Point(129, 13);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new System.Drawing.Size(403, 27);
            txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new System.Drawing.Point(13, 16);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(76, 20);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(950, 549);
            Controls.Add(panel);
            Controls.Add(btnSelectPdf);
            Controls.Add(txtPdfFilePath);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            grpWorkingExperience.ResumeLayout(false);
            grpWorkingExperience.PerformLayout();
            grpContact.ResumeLayout(false);
            grpContact.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtPdfFilePath;
        private System.Windows.Forms.Button btnSelectPdf;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtWorkingPlace;
        private System.Windows.Forms.Label lblWorkingPlace;
        private System.Windows.Forms.Label lblTopSkills;
        private System.Windows.Forms.TextBox txtTopSkills;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtLinkedIn;
        private System.Windows.Forms.Label lblLinkedIn;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox grpWorkingExperience;
        private System.Windows.Forms.TextBox txtOldCompany;
        private System.Windows.Forms.Label lblOldCompany;
        private System.Windows.Forms.TextBox txtOldTitle;
        private System.Windows.Forms.Label lblOldTitle;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtOthers;
        private System.Windows.Forms.Label lblOthers;
    }
}