using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(int productID) => ProductDAO.Instance.Remove(productID);

        public ProductObject GetProductByID(int productID) => ProductDAO.Instance.GetProductByID(productID);

        public IEnumerable<ProductObject> GetProducts() => ProductDAO.Instance.GetProducts();

        public void InsertProduct(ProductObject product) => ProductDAO.Instance.AddNew(product);

        public List<ProductObject> SearchProductByNameorID(string searchValue) => ProductDAO.Instance.SearchByNameOrID(searchValue);

        public List<ProductObject> SearchProductByUnit(string searchValue) => ProductDAO.Instance.SearchByUnit(searchValue);

        public void UpdateProduct(ProductObject product) => ProductDAO.Instance.Update(product);

    }
}
