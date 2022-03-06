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
    public partial class frmProducts : Form
    {
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;
        public frmProducts()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this product?";
            string title = "Confirm Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
                try
                {
                    var pro = GetProductObject();
                    productRepository.DeleteProduct(pro.ProductID);
                    LoadProductList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete a product");
                }
        }

        public void LoadProductList()
        {
            var pros = productRepository.GetProducts();
            string searchNameIDValue = txtSearchIDorName.Text;
            string searchUnitValue = txtSearchUnit.Text;
            string action = DoAction();
            if (action != "default")
            {
                switch (action)
                {
                    case "searchNameID":
                        pros = productRepository.SearchProductByNameorID(searchNameIDValue);
                        break;
                    case "searchUnit":
                        {
                            pros = productRepository.SearchProductByUnit(searchUnitValue);
                        }
                        break;
                }
            }
            try
            {
                source = new BindingSource();
                source.DataSource = pros;

                txtProductID.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitInStock.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductID");
                txtCategoryID.DataBindings.Add("Text", source, "CategoryID");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitInStock.DataBindings.Add("Text", source, "UnitsInStock");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;

                if (pros.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            };
        }

        private void ClearText()
        {
            txtProductID.Text = string.Empty;
            txtCategoryID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitInStock.Text = string.Empty;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick_1;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails
            {
                Text = "Add product",
                InsertOrUpdate = false,
                ProductRepository = productRepository
            };
            if (frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
                source.Position = source.Count - 1;
            }
        }

        private ProductObject GetProductObject()
        {
            ProductObject pro = null;
            try
            {
                pro = new ProductObject
                {
                    ProductID = int.Parse(txtProductID.Text),
                    CategoryID = int.Parse(txtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitInStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }
            return pro;
        }

        private void txtSearchIDorName_TextChanged(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void txtSearchUnit_TextChanged(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private string DoAction()
        {
            string action = "default";
            var searchNameIDValue = txtSearchIDorName.Text;
            var searchUnitValue = txtSearchUnit.Text;
            if (searchNameIDValue != null && !searchNameIDValue.Equals(""))
            {
                action = "searchNameID";
            } else if (searchUnitValue != null && !searchUnitValue.Equals(""))
            {
                action = "searchUnit";
            }
            return action;
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetails frmProductDetails = new frmProductDetails
            {
                Text = "Update member",
                InsertOrUpdate = true,
                ProductInfo = GetProductObject(),
                ProductRepository = productRepository
            };
            if (frmProductDetails.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
                source.Position = source.Count - 1;
            }
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            var pros = productRepository.GetProducts();
            try
            {
                source = new BindingSource();
                source.DataSource = pros;

                txtProductID.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitInStock.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductID");
                txtCategoryID.DataBindings.Add("Text", source, "CategoryID");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitInStock.DataBindings.Add("Text", source, "UnitsInStock");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;

                if (pros.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            };
        }
    }
}
