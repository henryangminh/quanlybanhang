namespace quanlybanhang_winform
{
    partial class formQuanLyBanHang
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
            this.tabConTrol = new System.Windows.Forms.TabControl();
            this.tbpThietBi = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.grvProduct = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTBName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxTBType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtTBGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQtyAdd = new System.Windows.Forms.TextBox();
            this.cbxAddProduct = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThietBiName = new System.Windows.Forms.TextBox();
            this.pnlTimThietBi = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSearchByType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbpLoaiThietBi = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEditProduct = new System.Windows.Forms.TextBox();
            this.cbxEditProductType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEditProductQty = new System.Windows.Forms.TextBox();
            this.txtPriceAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEditProductPrice = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tabConTrol.SuspendLayout();
            this.tbpThietBi.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlTimThietBi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConTrol
            // 
            this.tabConTrol.Controls.Add(this.tbpThietBi);
            this.tabConTrol.Controls.Add(this.tbpLoaiThietBi);
            this.tabConTrol.Controls.Add(this.tabPage3);
            this.tabConTrol.Controls.Add(this.tabPage1);
            this.tabConTrol.Controls.Add(this.tabPage2);
            this.tabConTrol.Controls.Add(this.tabPage4);
            this.tabConTrol.Location = new System.Drawing.Point(13, 13);
            this.tabConTrol.Name = "tabConTrol";
            this.tabConTrol.SelectedIndex = 0;
            this.tabConTrol.Size = new System.Drawing.Size(940, 604);
            this.tabConTrol.TabIndex = 0;
            // 
            // tbpThietBi
            // 
            this.tbpThietBi.Controls.Add(this.panel2);
            this.tbpThietBi.Controls.Add(this.panel1);
            this.tbpThietBi.Controls.Add(this.pnlTimThietBi);
            this.tbpThietBi.Location = new System.Drawing.Point(4, 22);
            this.tbpThietBi.Name = "tbpThietBi";
            this.tbpThietBi.Padding = new System.Windows.Forms.Padding(3);
            this.tbpThietBi.Size = new System.Drawing.Size(932, 578);
            this.tbpThietBi.TabIndex = 0;
            this.tbpThietBi.Text = "Thiết Bị";
            this.tbpThietBi.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblId);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtEditProductPrice);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtEditProductQty);
            this.panel2.Controls.Add(this.cbxEditProductType);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtEditProduct);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.grvProduct);
            this.panel2.Location = new System.Drawing.Point(7, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 359);
            this.panel2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label9.Location = new System.Drawing.Point(523, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Sửa";
            // 
            // grvProduct
            // 
            this.grvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.txtTBName,
            this.cbxTBType,
            this.txtTBGia,
            this.txtSoLuongTon,
            this.btnEditProduct});
            this.grvProduct.Location = new System.Drawing.Point(4, 4);
            this.grvProduct.Name = "grvProduct";
            this.grvProduct.Size = new System.Drawing.Size(514, 352);
            this.grvProduct.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // txtTBName
            // 
            this.txtTBName.HeaderText = "Tên Thiết Bị";
            this.txtTBName.Name = "txtTBName";
            this.txtTBName.ReadOnly = true;
            // 
            // cbxTBType
            // 
            this.cbxTBType.HeaderText = "Loại Thiết Bị";
            this.cbxTBType.Name = "cbxTBType";
            this.cbxTBType.ReadOnly = true;
            // 
            // txtTBGia
            // 
            this.txtTBGia.HeaderText = "Giá";
            this.txtTBGia.Name = "txtTBGia";
            this.txtTBGia.ReadOnly = true;
            this.txtTBGia.Width = 70;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.HeaderText = "Số Lượng Tồn";
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.ReadOnly = true;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.HeaderText = "";
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEditProduct.Text = "Sửa";
            this.btnEditProduct.UseColumnTextForButtonValue = true;
            this.btnEditProduct.Width = 50;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPriceAdd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtQtyAdd);
            this.panel1.Controls.Add(this.cbxAddProduct);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtThietBiName);
            this.panel1.Location = new System.Drawing.Point(7, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 142);
            this.panel1.TabIndex = 1;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(364, 106);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số Lượng";
            // 
            // txtQtyAdd
            // 
            this.txtQtyAdd.Location = new System.Drawing.Point(83, 75);
            this.txtQtyAdd.Name = "txtQtyAdd";
            this.txtQtyAdd.Size = new System.Drawing.Size(297, 20);
            this.txtQtyAdd.TabIndex = 11;
            // 
            // cbxAddProduct
            // 
            this.cbxAddProduct.FormattingEnabled = true;
            this.cbxAddProduct.Location = new System.Drawing.Point(489, 46);
            this.cbxAddProduct.Name = "cbxAddProduct";
            this.cbxAddProduct.Size = new System.Drawing.Size(227, 21);
            this.cbxAddProduct.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(14, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thêm Thiết Bị Mới";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Loại Thiết Bị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Thiết Bị";
            // 
            // txtThietBiName
            // 
            this.txtThietBiName.Location = new System.Drawing.Point(83, 48);
            this.txtThietBiName.Name = "txtThietBiName";
            this.txtThietBiName.Size = new System.Drawing.Size(297, 20);
            this.txtThietBiName.TabIndex = 5;
            // 
            // pnlTimThietBi
            // 
            this.pnlTimThietBi.Controls.Add(this.label5);
            this.pnlTimThietBi.Controls.Add(this.cbxSearchByType);
            this.pnlTimThietBi.Controls.Add(this.label2);
            this.pnlTimThietBi.Controls.Add(this.label1);
            this.pnlTimThietBi.Controls.Add(this.txtSearchByName);
            this.pnlTimThietBi.Controls.Add(this.btnSearch);
            this.pnlTimThietBi.Location = new System.Drawing.Point(6, 6);
            this.pnlTimThietBi.Name = "pnlTimThietBi";
            this.pnlTimThietBi.Size = new System.Drawing.Size(920, 52);
            this.pnlTimThietBi.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label5.Location = new System.Drawing.Point(15, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tìm";
            // 
            // cbxSearchByType
            // 
            this.cbxSearchByType.FormattingEnabled = true;
            this.cbxSearchByType.Location = new System.Drawing.Point(523, 12);
            this.cbxSearchByType.Name = "cbxSearchByType";
            this.cbxSearchByType.Size = new System.Drawing.Size(227, 21);
            this.cbxSearchByType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm theo loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm theo tên";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(146, 14);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(297, 20);
            this.txtSearchByName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(756, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbpLoaiThietBi
            // 
            this.tbpLoaiThietBi.Location = new System.Drawing.Point(4, 22);
            this.tbpLoaiThietBi.Name = "tbpLoaiThietBi";
            this.tbpLoaiThietBi.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLoaiThietBi.Size = new System.Drawing.Size(932, 578);
            this.tbpLoaiThietBi.TabIndex = 1;
            this.tbpLoaiThietBi.Text = "Loại Thiết Bị";
            this.tbpLoaiThietBi.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(932, 578);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Hóa Đơn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(932, 578);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Chi tiết hóa đơn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(932, 578);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Khách Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.ForeColor = System.Drawing.Color.Coral;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(932, 578);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "Giao Hàng";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(524, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tên Thiết Bị";
            // 
            // txtEditProduct
            // 
            this.txtEditProduct.Location = new System.Drawing.Point(596, 42);
            this.txtEditProduct.Name = "txtEditProduct";
            this.txtEditProduct.Size = new System.Drawing.Size(297, 20);
            this.txtEditProduct.TabIndex = 15;
            // 
            // cbxEditProductType
            // 
            this.cbxEditProductType.FormattingEnabled = true;
            this.cbxEditProductType.Location = new System.Drawing.Point(597, 66);
            this.cbxEditProductType.Name = "cbxEditProductType";
            this.cbxEditProductType.Size = new System.Drawing.Size(227, 21);
            this.cbxEditProductType.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(523, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Loại Thiết Bị";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(524, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Số Lượng";
            // 
            // txtEditProductQty
            // 
            this.txtEditProductQty.Location = new System.Drawing.Point(597, 91);
            this.txtEditProductQty.Name = "txtEditProductQty";
            this.txtEditProductQty.Size = new System.Drawing.Size(297, 20);
            this.txtEditProductQty.TabIndex = 15;
            // 
            // txtPriceAdd
            // 
            this.txtPriceAdd.Location = new System.Drawing.Point(488, 75);
            this.txtPriceAdd.Name = "txtPriceAdd";
            this.txtPriceAdd.Size = new System.Drawing.Size(297, 20);
            this.txtPriceAdd.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Giá";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(525, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Giá";
            // 
            // txtEditProductPrice
            // 
            this.txtEditProductPrice.Location = new System.Drawing.Point(597, 117);
            this.txtEditProductPrice.Name = "txtEditProductPrice";
            this.txtEditProductPrice.Size = new System.Drawing.Size(297, 20);
            this.txtEditProductPrice.TabIndex = 15;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(674, 148);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Cập Nhật";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(597, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Thiết bị Id: ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(656, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 13);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "xxx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 629);
            this.Controls.Add(this.tabConTrol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabConTrol.ResumeLayout(false);
            this.tbpThietBi.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTimThietBi.ResumeLayout(false);
            this.pnlTimThietBi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConTrol;
        private System.Windows.Forms.TabPage tbpThietBi;
        private System.Windows.Forms.TabPage tbpLoaiThietBi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel pnlTimThietBi;
        private System.Windows.Forms.ComboBox cbxSearchByType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThietBiName;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQtyAdd;
        private System.Windows.Forms.ComboBox cbxAddProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTBName;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxTBType;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTBGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSoLuongTon;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEditProductPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEditProductQty;
        private System.Windows.Forms.ComboBox cbxEditProductType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEditProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPriceAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label14;
    }
}

