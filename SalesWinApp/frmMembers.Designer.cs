
namespace SalesWinApp
{
    partial class frmMembers
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
            this.grbProductView = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.grbControl = new System.Windows.Forms.GroupBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.grbView = new System.Windows.Forms.GroupBox();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.grbProductView.SuspendLayout();
            this.grbControl.SuspendLayout();
            this.grbView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProductView
            // 
            this.grbProductView.Controls.Add(this.txtPassword);
            this.grbProductView.Controls.Add(this.txtCountry);
            this.grbProductView.Controls.Add(this.txtCity);
            this.grbProductView.Controls.Add(this.txtCompanyName);
            this.grbProductView.Controls.Add(this.txtEmail);
            this.grbProductView.Controls.Add(this.txtMemberID);
            this.grbProductView.Controls.Add(this.lbPassword);
            this.grbProductView.Controls.Add(this.lbCountry);
            this.grbProductView.Controls.Add(this.lbCity);
            this.grbProductView.Controls.Add(this.lbCompanyName);
            this.grbProductView.Controls.Add(this.lbEmail);
            this.grbProductView.Controls.Add(this.lbMemberID);
            this.grbProductView.Location = new System.Drawing.Point(12, 12);
            this.grbProductView.Name = "grbProductView";
            this.grbProductView.Size = new System.Drawing.Size(776, 197);
            this.grbProductView.TabIndex = 0;
            this.grbProductView.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(515, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(190, 27);
            this.txtPassword.TabIndex = 11;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(515, 83);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(190, 27);
            this.txtCountry.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(515, 37);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(190, 27);
            this.txtCity.TabIndex = 9;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(168, 130);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(190, 27);
            this.txtCompanyName.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(168, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 27);
            this.txtEmail.TabIndex = 7;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(168, 37);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(190, 27);
            this.txtMemberID.TabIndex = 6;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(428, 133);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(428, 86);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 4;
            this.lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(428, 40);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 3;
            this.lbCity.Text = "City";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(35, 133);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(116, 20);
            this.lbCompanyName.TabIndex = 2;
            this.lbCompanyName.Text = "Company Name";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(35, 86);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(35, 40);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(84, 20);
            this.lbMemberID.TabIndex = 0;
            this.lbMemberID.Text = "Member ID";
            // 
            // grbControl
            // 
            this.grbControl.Controls.Add(this.BtnLoad);
            this.grbControl.Controls.Add(this.btnDelete);
            this.grbControl.Controls.Add(this.btnNew);
            this.grbControl.Location = new System.Drawing.Point(12, 215);
            this.grbControl.Name = "grbControl";
            this.grbControl.Size = new System.Drawing.Size(776, 81);
            this.grbControl.TabIndex = 1;
            this.grbControl.TabStop = false;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(279, 29);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(94, 29);
            this.BtnLoad.TabIndex = 3;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(155, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(35, 29);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // grbView
            // 
            this.grbView.Controls.Add(this.dgvMemberList);
            this.grbView.Location = new System.Drawing.Point(13, 303);
            this.grbView.Name = "grbView";
            this.grbView.Size = new System.Drawing.Size(775, 221);
            this.grbView.TabIndex = 2;
            this.grbView.TabStop = false;
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(6, 17);
            this.dgvMemberList.MultiSelect = false;
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 29;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(763, 198);
            this.dgvMemberList.TabIndex = 0;
            this.dgvMemberList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellDoubleClick);
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.grbView);
            this.Controls.Add(this.grbControl);
            this.Controls.Add(this.grbProductView);
            this.Name = "frmMembers";
            this.Text = "frmMembers";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            this.grbProductView.ResumeLayout(false);
            this.grbProductView.PerformLayout();
            this.grbControl.ResumeLayout(false);
            this.grbView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProductView;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.GroupBox grbControl;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox grbView;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Button BtnLoad;
    }
}