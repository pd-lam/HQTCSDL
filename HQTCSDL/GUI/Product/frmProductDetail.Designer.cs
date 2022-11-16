namespace HQTCSDL.GUI.Product
{
    partial class frmProductDetail
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txbStreet = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbFistName = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lbCateId = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbModelYear = new System.Windows.Forms.Label();
            this.lbCateName = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbProductId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(734, 55);
            this.panelTitleBar.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(286, 55);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Thông tin sản phẩm";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(572, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 60);
            this.btnSave.TabIndex = 96;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(573, 98);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 60);
            this.btnEdit.TabIndex = 95;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // txbStreet
            // 
            this.txbStreet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbStreet.Location = new System.Drawing.Point(196, 284);
            this.txbStreet.Name = "txbStreet";
            this.txbStreet.Size = new System.Drawing.Size(333, 34);
            this.txbStreet.TabIndex = 94;
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbEmail.Location = new System.Drawing.Point(196, 244);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(333, 34);
            this.txbEmail.TabIndex = 93;
            // 
            // txbPhone
            // 
            this.txbPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPhone.Location = new System.Drawing.Point(196, 204);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(333, 34);
            this.txbPhone.TabIndex = 92;
            // 
            // txbLastName
            // 
            this.txbLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbLastName.Location = new System.Drawing.Point(196, 164);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(333, 34);
            this.txbLastName.TabIndex = 91;
            // 
            // txbFistName
            // 
            this.txbFistName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbFistName.Location = new System.Drawing.Point(196, 124);
            this.txbFistName.Name = "txbFistName";
            this.txbFistName.Size = new System.Drawing.Size(333, 34);
            this.txbFistName.TabIndex = 90;
            // 
            // txbId
            // 
            this.txbId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbId.Location = new System.Drawing.Point(196, 84);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(333, 34);
            this.txbId.TabIndex = 89;
            // 
            // lbCateId
            // 
            this.lbCateId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCateId.AutoSize = true;
            this.lbCateId.Location = new System.Drawing.Point(22, 167);
            this.lbCateId.Name = "lbCateId";
            this.lbCateId.Size = new System.Drawing.Size(166, 28);
            this.lbCateId.TabIndex = 88;
            this.lbCateId.Text = "Mã loại sản phẩm";
            // 
            // lbPrice
            // 
            this.lbPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(19, 287);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(41, 28);
            this.lbPrice.TabIndex = 87;
            this.lbPrice.Text = "Giá";
            // 
            // lbModelYear
            // 
            this.lbModelYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbModelYear.AutoSize = true;
            this.lbModelYear.Location = new System.Drawing.Point(19, 247);
            this.lbModelYear.Name = "lbModelYear";
            this.lbModelYear.Size = new System.Drawing.Size(110, 28);
            this.lbModelYear.TabIndex = 86;
            this.lbModelYear.Text = "Năm ra đời";
            // 
            // lbCateName
            // 
            this.lbCateName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCateName.AutoSize = true;
            this.lbCateName.Location = new System.Drawing.Point(22, 207);
            this.lbCateName.Name = "lbCateName";
            this.lbCateName.Size = new System.Drawing.Size(137, 28);
            this.lbCateName.TabIndex = 85;
            this.lbCateName.Text = "Loại sản phẩm";
            // 
            // lbProductName
            // 
            this.lbProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(22, 127);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(130, 28);
            this.lbProductName.TabIndex = 84;
            this.lbProductName.Text = "Tên sản phẩm";
            // 
            // lbProductId
            // 
            this.lbProductId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProductId.AutoSize = true;
            this.lbProductId.Location = new System.Drawing.Point(22, 87);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(129, 28);
            this.lbProductId.TabIndex = 83;
            this.lbProductId.Text = "Mã sản phẩm";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(573, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 60);
            this.btnCancel.TabIndex = 82;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(734, 349);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txbStreet);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbFistName);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lbCateId);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbModelYear);
            this.Controls.Add(this.lbCateName);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProductDetail";
            this.Text = "frmProductDetail";
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txbStreet;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbFistName;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lbCateId;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbModelYear;
        private System.Windows.Forms.Label lbCateName;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbProductId;
        private System.Windows.Forms.Button btnCancel;
    }
}