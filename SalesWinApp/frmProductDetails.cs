using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductDetails : Form
    {
        public frmProductDetails()
        {
            InitializeComponent();
        }

        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public ProductObject ProductInfo { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var pro = new ProductObject
                {
                    ProductID = int.Parse(txtProductID.Text),
                    CategoryID = int.Parse(txtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitInStock.Text)
                };
                if (InsertOrUpdate == false)
                {
                    ProductRepository.InsertProduct(pro);
                }
                else
                {
                    ProductRepository.UpdateProduct(pro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new product" : "Update a product");
            }
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            txtProductID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtProductID.Text = ProductInfo.ProductID.ToString();
                txtCategoryID.Text = ProductInfo.CategoryID.ToString();
                txtProductName.Text = ProductInfo.ProductName.ToString();
                txtWeight.Text = ProductInfo.Weight.ToString();
                txtUnitPrice.Text = ProductInfo.UnitPrice.ToString();
                txtUnitInStock.Text = ProductInfo.UnitsInStock.ToString();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
