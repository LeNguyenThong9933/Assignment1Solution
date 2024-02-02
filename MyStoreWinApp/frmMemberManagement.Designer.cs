namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            dgvMemberList = new DataGridView();
            lbID = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnClose = new Button();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            cboSearch = new ComboBox();
            txtSearch = new TextBox();
            btnSort = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(12, 199);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(776, 235);
            dgvMemberList.TabIndex = 0;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(32, 22);
            lbID.Name = "lbID";
            lbID.Size = new Size(24, 20);
            lbID.TabIndex = 1;
            lbID.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(97, 22);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(82, 27);
            txtID.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(97, 55);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(173, 27);
            txtName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 55);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(97, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(173, 27);
            txtEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 88);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 27);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 9;
            label4.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(400, 62);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 10;
            label5.Text = "City";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(365, 450);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(190, 153);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(363, 153);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 13;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(517, 153);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(473, 22);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(150, 27);
            txtCountry.TabIndex = 15;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(473, 62);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(150, 27);
            txtCity.TabIndex = 16;
            // 
            // cboSearch
            // 
            cboSearch.FormattingEnabled = true;
            cboSearch.Items.AddRange(new object[] { "ID", "Name" });
            cboSearch.Location = new Point(400, 95);
            cboSearch.Name = "cboSearch";
            cboSearch.Size = new Size(60, 28);
            cboSearch.TabIndex = 17;
            cboSearch.SelectedIndexChanged += cboSearch_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(473, 96);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(172, 27);
            txtSearch.TabIndex = 18;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(276, 58);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(47, 29);
            btnSort.TabIndex = 19;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click_1;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(btnSort);
            Controls.Add(txtSearch);
            Controls.Add(cboSearch);
            Controls.Add(txtCity);
            Controls.Add(txtCountry);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(btnClose);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(lbID);
            Controls.Add(dgvMemberList);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Management";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMemberList;
        private Label lbID;
        private TextBox txtID;
        private TextBox txtName;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnClose;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private TextBox txtCountry;
        private TextBox txtCity;
        private ComboBox cboSearch;
        private TextBox txtSearch;
        private Button btnSort;
    }
}
