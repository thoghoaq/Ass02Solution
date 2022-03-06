
namespace SalesWinApp
{
    partial class frmProducts
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
            this.grProductDetail = new System.Windows.Forms.GroupBox();
            this.txtUnitInStock = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lbUnitInStock = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.lbProductId = new System.Windows.Forms.Label();
            this.grbControl = new System.Windows.Forms.GroupBox();
            this.txtSearchUnit = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtSearchIDorName = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.grbProductView = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grProductDetail.SuspendLayout();
            this.grbControl.SuspendLayout();
            this.grbProductView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grProductDetail
            // 
            this.grProductDetail.Controls.Add(this.txtUnitInStock);
            this.grProductDetail.Controls.Add(this.txtUnitPrice);
            this.grProductDetail.Controls.Add(this.txtWeight);
            this.grProductDetail.Controls.Add(this.txtProductName);
            this.grProductDetail.Controls.Add(this.txtCategoryID);
            this.grProductDetail.Controls.Add(this.txtProductID);
            this.grProductDetail.Controls.Add(this.lbUnitInStock);
            this.grProductDetail.Controls.Add(this.lbUnitPrice);
            this.grProductDetail.Controls.Add(this.lbWeight);
            this.grProductDetail.Controls.Add(this.lbProductName);
            this.grProductDetail.Controls.Add(this.lbCategoryID);
            this.grProductDetail.Controls.Add(this.lbProductId);
            this.grProductDetail.Location = new System.Drawing.Point(38, 22);
            this.grProductDetail.Name = "grProductDetail";
            this.grProductDetail.Size = new System.Drawing.Size(728, 200);
            this.grProductDetail.TabIndex = 0;
            this.grProductDetail.TabStop = false;
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Location = new System.Drawing.Point(489, 136);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(182, 27);
            this.txtUnitInStock.TabIndex = 11;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(489, 86);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(182, 27);
            this.txtUnitPrice.TabIndex = 10;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(489, 33);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(182, 27);
            this.txtWeight.TabIndex = 9;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(154, 136);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(179, 27);
            this.txtProductName.TabIndex = 8;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(154, 86);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(179, 27);
            this.txtCategoryID.TabIndex = 7;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(154, 33);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(179, 27);
            this.txtProductID.TabIndex = 6;
            // 
            // lbUnitInStock
            // 
            this.lbUnitInStock.AutoSize = true;
            this.lbUnitInStock.Location = new System.Drawing.Point(378, 139);
            this.lbUnitInStock.Name = "lbUnitInStock";
            this.lbUnitInStock.Size = new System.Drawing.Size(92, 20);
            this.lbUnitInStock.TabIndex = 5;
            this.lbUnitInStock.Text = "Unit In Stock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(378, 89);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 4;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(378, 36);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(56, 20);
            this.lbWeight.TabIndex = 3;
            this.lbWeight.Text = "Weight";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(31, 139);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 2;
            this.lbProductName.Text = "Product Name";
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Location = new System.Drawing.Point(31, 89);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(88, 20);
            this.lbCategoryID.TabIndex = 1;
            this.lbCategoryID.Text = "Category ID";
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Location = new System.Drawing.Point(31, 36);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(79, 20);
            this.lbProductId.TabIndex = 0;
            this.lbProductId.Text = "Product ID";
            // 
            // grbControl
            // 
            this.grbControl.Controls.Add(this.txtSearchUnit);
            this.grbControl.Controls.Add(this.lbSearch);
            this.grbControl.Controls.Add(this.txtSearchIDorName);
            this.grbControl.Controls.Add(this.btnLoad);
            this.grbControl.Controls.Add(this.btnDelete);
            this.grbControl.Controls.Add(this.btnNew);
            this.grbControl.Location = new System.Drawing.Point(38, 228);
            this.grbControl.Name = "grbControl";
            this.grbControl.Size = new System.Drawing.Size(728, 75);
            this.grbControl.TabIndex = 1;
            this.grbControl.TabStop = false;
            // 
            // txtSearchUnit
            // 
            this.txtSearchUnit.Location = new System.Drawing.Point(585, 27);
            this.txtSearchUnit.Name = "txtSearchUnit";
            this.txtSearchUnit.PlaceholderText = "Unit";
            this.txtSearchUnit.Size = new System.Drawing.Size(124, 27);
            this.txtSearchUnit.TabIndex = 5;
            this.txtSearchUnit.TextChanged += new System.EventHandler(this.txtSearchUnit_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(316, 31);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(53, 20);
            this.lbSearch.TabIndex = 4;
            this.lbSearch.Text = "Search";
            // 
            // txtSearchIDorName
            // 
            this.txtSearchIDorName.Location = new System.Drawing.Point(375, 28);
            this.txtSearchIDorName.Name = "txtSearchIDorName";
            this.txtSearchIDorName.PlaceholderText = "ID or Name";
            this.txtSearchIDorName.Size = new System.Drawing.Size(189, 27);
            this.txtSearchIDorName.TabIndex = 3;
            this.txtSearchIDorName.TextChanged += new System.EventHandler(this.txtSearchIDorName_TextChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(216, 26);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(116, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(16, 26);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // grbProductView
            // 
            this.grbProductView.Controls.Add(this.dataGridView1);
            this.grbProductView.Location = new System.Drawing.Point(38, 309);
            this.grbProductView.Name = "grbProductView";
            this.grbProductView.Size = new System.Drawing.Size(728, 231);
            this.grbProductView.TabIndex = 2;
            this.grbProductView.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(715, 206);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.grbProductView);
            this.Controls.Add(this.grbControl);
            this.Controls.Add(this.grProductDetail);
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.grProductDetail.ResumeLayout(false);
            this.grProductDetail.PerformLayout();
            this.grbControl.ResumeLayout(false);
            this.grbControl.PerformLayout();
            this.grbProductView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grProductDetail;
        private System.Windows.Forms.GroupBox grbControl;
        private System.Windows.Forms.GroupBox grbProductView;
        private System.Windows.Forms.TextBox txtUnitInStock;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lbUnitInStock;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbProductId;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearchIDorName;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchUnit;
    }
}