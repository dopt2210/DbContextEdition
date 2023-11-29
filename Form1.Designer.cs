namespace DbContextEdition
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gDetails = new System.Windows.Forms.GroupBox();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.cbxDungtich = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHangxe = new System.Windows.Forms.TextBox();
            this.txtSomay = new System.Windows.Forms.TextBox();
            this.txtSokhung = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtTenxe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMamau = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sokhung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Somay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mamau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dungtichxilanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hangxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sokhung,
            this.Somay,
            this.Mamau,
            this.Dungtichxilanh,
            this.Hangxe,
            this.Tenxe,
            this.Anh});
            this.dgv.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv.Location = new System.Drawing.Point(13, 270);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(652, 265);
            this.dgv.TabIndex = 1;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // gDetails
            // 
            this.gDetails.Controls.Add(this.txtMamau);
            this.gDetails.Controls.Add(this.txtTenxe);
            this.gDetails.Controls.Add(this.imgBox);
            this.gDetails.Controls.Add(this.btnImage);
            this.gDetails.Controls.Add(this.cbxDungtich);
            this.gDetails.Controls.Add(this.label5);
            this.gDetails.Controls.Add(this.label3);
            this.gDetails.Controls.Add(this.label4);
            this.gDetails.Controls.Add(this.btnSave);
            this.gDetails.Controls.Add(this.btnCancel);
            this.gDetails.Controls.Add(this.label8);
            this.gDetails.Controls.Add(this.label7);
            this.gDetails.Controls.Add(this.label2);
            this.gDetails.Controls.Add(this.label1);
            this.gDetails.Controls.Add(this.txtHangxe);
            this.gDetails.Controls.Add(this.txtSomay);
            this.gDetails.Controls.Add(this.txtSokhung);
            this.gDetails.Controls.Add(this.txtId);
            this.gDetails.Location = new System.Drawing.Point(13, 22);
            this.gDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gDetails.Name = "gDetails";
            this.gDetails.Padding = new System.Windows.Forms.Padding(4);
            this.gDetails.Size = new System.Drawing.Size(974, 220);
            this.gDetails.TabIndex = 1;
            this.gDetails.TabStop = false;
            this.gDetails.Text = "Details";
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(664, 13);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(150, 200);
            this.imgBox.TabIndex = 10;
            this.imgBox.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(854, 26);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(100, 40);
            this.btnImage.TabIndex = 9;
            this.btnImage.Text = "Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // cbxDungtich
            // 
            this.cbxDungtich.FormattingEnabled = true;
            this.cbxDungtich.Items.AddRange(new object[] {
            "50",
            "70",
            "100",
            "110",
            "150"});
            this.cbxDungtich.Location = new System.Drawing.Point(421, 20);
            this.cbxDungtich.Name = "cbxDungtich";
            this.cbxDungtich.Size = new System.Drawing.Size(200, 28);
            this.cbxDungtich.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dung tich xi lanh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hang xe";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(854, 95);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(854, 160);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "So may";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "So khung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id:";
            // 
            // txtHangxe
            // 
            this.txtHangxe.Location = new System.Drawing.Point(421, 60);
            this.txtHangxe.Margin = new System.Windows.Forms.Padding(4);
            this.txtHangxe.Name = "txtHangxe";
            this.txtHangxe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHangxe.Size = new System.Drawing.Size(200, 26);
            this.txtHangxe.TabIndex = 2;
            // 
            // txtSomay
            // 
            this.txtSomay.Location = new System.Drawing.Point(96, 101);
            this.txtSomay.Margin = new System.Windows.Forms.Padding(4);
            this.txtSomay.Name = "txtSomay";
            this.txtSomay.Size = new System.Drawing.Size(200, 26);
            this.txtSomay.TabIndex = 2;
            // 
            // txtSokhung
            // 
            this.txtSokhung.Location = new System.Drawing.Point(96, 60);
            this.txtSokhung.Margin = new System.Windows.Forms.Padding(4);
            this.txtSokhung.Name = "txtSokhung";
            this.txtSokhung.Size = new System.Drawing.Size(200, 26);
            this.txtSokhung.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(45, 20);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 26);
            this.txtId.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(773, 495);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(687, 281);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(125, 40);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "Load";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(842, 410);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 40);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(842, 281);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(687, 348);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(125, 40);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(687, 410);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(125, 40);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(842, 348);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 40);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtTenxe
            // 
            this.txtTenxe.Location = new System.Drawing.Point(421, 102);
            this.txtTenxe.Name = "txtTenxe";
            this.txtTenxe.Size = new System.Drawing.Size(200, 26);
            this.txtTenxe.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ten xe";
            // 
            // txtMamau
            // 
            this.txtMamau.Location = new System.Drawing.Point(96, 149);
            this.txtMamau.Name = "txtMamau";
            this.txtMamau.Size = new System.Drawing.Size(100, 26);
            this.txtMamau.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mau";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Sokhung
            // 
            this.Sokhung.HeaderText = "So khung";
            this.Sokhung.MinimumWidth = 6;
            this.Sokhung.Name = "Sokhung";
            this.Sokhung.ReadOnly = true;
            // 
            // Somay
            // 
            this.Somay.HeaderText = "So may";
            this.Somay.MinimumWidth = 6;
            this.Somay.Name = "Somay";
            this.Somay.ReadOnly = true;
            // 
            // Mamau
            // 
            this.Mamau.HeaderText = "Ma mau";
            this.Mamau.MinimumWidth = 6;
            this.Mamau.Name = "Mamau";
            this.Mamau.ReadOnly = true;
            // 
            // Dungtichxilanh
            // 
            this.Dungtichxilanh.HeaderText = "DungTichXiLanh";
            this.Dungtichxilanh.MinimumWidth = 6;
            this.Dungtichxilanh.Name = "Dungtichxilanh";
            this.Dungtichxilanh.ReadOnly = true;
            // 
            // Hangxe
            // 
            this.Hangxe.HeaderText = "Hang xe";
            this.Hangxe.MinimumWidth = 6;
            this.Hangxe.Name = "Hangxe";
            this.Hangxe.ReadOnly = true;
            // 
            // Tenxe
            // 
            this.Tenxe.HeaderText = "Ten Xe";
            this.Tenxe.MinimumWidth = 6;
            this.Tenxe.Name = "Tenxe";
            this.Tenxe.ReadOnly = true;
            // 
            // Anh
            // 
            this.Anh.HeaderText = "Anh";
            this.Anh.MinimumWidth = 6;
            this.Anh.Name = "Anh";
            this.Anh.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.gDetails);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gDetails.ResumeLayout(false);
            this.gDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox gDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSokhung;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHangxe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxDungtich;
        private System.Windows.Forms.BindingSource tNhanVienBindingSource1;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtSomay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.TextBox txtTenxe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMamau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sokhung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Somay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mamau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dungtichxilanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hangxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anh;
    }
}

