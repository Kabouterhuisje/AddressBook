namespace AddressBook
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.gbPeople = new System.Windows.Forms.GroupBox();
            this.lvPeople = new System.Windows.Forms.ListView();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPeople.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPeople
            // 
            this.gbPeople.Controls.Add(this.lvPeople);
            this.gbPeople.Location = new System.Drawing.Point(12, 12);
            this.gbPeople.Name = "gbPeople";
            this.gbPeople.Size = new System.Drawing.Size(200, 473);
            this.gbPeople.TabIndex = 0;
            this.gbPeople.TabStop = false;
            this.gbPeople.Text = "People";
            // 
            // lvPeople
            // 
            this.lvPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPeople.Location = new System.Drawing.Point(3, 16);
            this.lvPeople.Name = "lvPeople";
            this.lvPeople.Size = new System.Drawing.Size(194, 454);
            this.lvPeople.TabIndex = 0;
            this.lvPeople.UseCompatibleStateImageBehavior = false;
            this.lvPeople.SelectedIndexChanged += new System.EventHandler(this.lvPeople_SelectedIndexChanged);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.btnRemove);
            this.gbInfo.Controls.Add(this.btnAdd);
            this.gbInfo.Controls.Add(this.btnSave);
            this.gbInfo.Controls.Add(this.txtExtra);
            this.gbInfo.Controls.Add(this.lblExtra);
            this.gbInfo.Controls.Add(this.dtpBirthday);
            this.gbInfo.Controls.Add(this.lblBirthday);
            this.gbInfo.Controls.Add(this.txtStreet);
            this.gbInfo.Controls.Add(this.lblStreet);
            this.gbInfo.Controls.Add(this.txtMail);
            this.gbInfo.Controls.Add(this.lblMail);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.lblName);
            this.gbInfo.Location = new System.Drawing.Point(218, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(585, 473);
            this.gbInfo.TabIndex = 1;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(414, 433);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(221, 433);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Contact";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(22, 198);
            this.txtExtra.Multiline = true;
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(542, 218);
            this.txtExtra.TabIndex = 9;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(19, 172);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(86, 13);
            this.lblExtra.TabIndex = 8;
            this.lblExtra.Text = "Extra Information";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(103, 141);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(453, 20);
            this.dtpBirthday.TabIndex = 7;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(19, 141);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(45, 13);
            this.lblBirthday.TabIndex = 6;
            this.lblBirthday.Text = "Birthday";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(103, 106);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(453, 20);
            this.txtStreet.TabIndex = 5;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(19, 106);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(76, 13);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Street Address";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(103, 69);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(453, 20);
            this.txtMail.TabIndex = 3;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(19, 69);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(73, 13);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Email Address";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(453, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 497);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbPeople);
            this.Name = "Form1";
            this.Text = "Address Book by Kabouterhuisje";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPeople.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPeople;
        private System.Windows.Forms.ListView lvPeople;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}

