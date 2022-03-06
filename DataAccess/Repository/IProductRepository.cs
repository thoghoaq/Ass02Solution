using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<ProductObject> GetProducts();
        ProductObject GetProductByID(int productID);
        void InsertProduct(ProductObject product);
        void DeleteProduct(int productID);
        void UpdateProduct(ProductObject product);

        List<ProductObject> SearchProductByNameorID(string searchValue);
        List<ProductObject> SearchProductByUnit(string searchValue);
    }
}
