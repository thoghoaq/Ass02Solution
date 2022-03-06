
namespace SalesWinApp
{
    partial class frmOrders
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
            this.grbDetail = new System.Windows.Forms.GroupBox();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.lbFreight = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.grbOrderDetail = new System.Windows.Forms.GroupBox();
            this.lbProductID = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbDetail.SuspendLayout();
            this.grbOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDetail
            // 
            this.grbDetail.Controls.Add(this.txtFreight);
            this.grbDetail.Controls.Add(this.txtShippedDate);
            this.grbDetail.Controls.Add(this.txtRequiredDate);
            this.grbDetail.Controls.Add(this.txtOrderDate);
            this.grbDetail.Controls.Add(this.txtMemberID);
            this.grbDetail.Controls.Add(this.txtOrderID);
            this.grbDetail.Controls.Add(this.lbFreight);
            this.grbDetail.Controls.Add(this.lbShippedDate);
            this.grbDetail.Controls.Add(this.lbRequiredDate);
            this.grbDetail.Controls.Add(this.lbOrderDate);
            this.grbDetail.Controls.Add(this.lbMemberID);
            this.grbDetail.Controls.Add(this.lbOrderID);
            this.grbDetail.Location = new System.Drawing.Point(24, 22);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(752, 159);
            this.grbDetail.TabIndex = 0;
            this.grbDetail.TabStop = false;
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(27, 33);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(66, 20);
            this.lbOrderID.TabIndex = 0;
            this.lbOrderID.Text = "Order ID";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(27, 72);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(80, 20);
            this.lbMemberID.TabIndex = 1;
            this.lbMemberID.Text = "MemberID";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(27, 110);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(83, 20);
            this.lbOrderDate.TabIndex = 2;
            this.lbOrderDate.Text = "Order Date";
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(364, 33);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(105, 20);
            this.lbRequiredDate.TabIndex = 3;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(364, 72);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(100, 20);
            this.lbShippedDate.TabIndex = 4;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(364, 110);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(55, 20);
            this.lbFreight.TabIndex = 5;
            this.lbFreight.Text = "Freight";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(126, 30);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(203, 27);
            this.txtOrderID.TabIndex = 6;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(126, 69);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(203, 27);
            this.txtMemberID.TabIndex = 7;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(126, 107);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(203, 27);
            this.txtOrderDate.TabIndex = 8;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(513, 30);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(203, 27);
            this.txtRequiredDate.TabIndex = 9;
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(513, 69);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(203, 27);
            this.txtShippedDate.TabIndex = 10;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(513, 107);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(203, 27);
            this.txtFreight.TabIndex = 11;
            // 
            // grbOrderDetail
            // 
            this.grbOrderDetail.Controls.Add(this.btnRemove);
            this.grbOrderDetail.Controls.Add(this.btnAddItem);
            this.grbOrderDetail.Controls.Add(this.txtQuantity);
            this.grbOrderDetail.Controls.Add(this.lbQuantity);
            this.grbOrderDetail.Controls.Add(this.comboBox1);
            this.grbOrderDetail.Controls.Add(this.lbProductID);
            this.grbOrderDetail.Location = new System.Drawing.Point(24, 187);
            this.grbOrderDetail.Name = "grbOrderDetail";
            this.grbOrderDetail.Size = new System.Drawing.Size(752, 81);
            this.grbOrderDetail.TabIndex = 1;
            this.grbOrderDetail.TabStop = false;
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(27, 32);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(79, 20);
            this.lbProductID.TabIndex = 0;
            this.lbProductID.Text = "Product ID";
            this.lbProductID.Click += new System.EventHandler(this.lbProductID_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(340, 32);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(65, 20);
            this.lbQuantity.TabIndex = 2;
            this.lbQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(411, 29);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(125, 27);
            this.txtQuantity.TabIndex = 3;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(555, 29);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(94, 29);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(24, 274);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 29;
            this.dgvOrderDetail.Size = new System.Drawing.Size(752, 188);
            this.dgvOrderDetail.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 478);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(67, 481);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(67, 20);
            this.lbDiscount.TabIndex = 4;
            this.lbDiscount.Text = "Discount";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(323, 481);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(141, 20);
            this.lbTotal.TabIndex = 5;
            this.lbTotal.Text = "Total Amount: 00.00";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(603, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(655, 29);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(87, 29);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.grbOrderDetail);
            this.Controls.Add(this.grbDetail);
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.grbDetail.ResumeLayout(false);
            this.grbDetail.PerformLayout();
            this.grbOrderDetail.ResumeLayout(false);
            this.grbOrderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDetail;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.GroupBox grbOrderDetail;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}