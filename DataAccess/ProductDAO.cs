using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class ProductDAO : BaseDAL
    {
        public List<ProductObject> GetProducts()
        {
            IDataReader dataReader = null;
            var list = new List<ProductObject>();
            string SQLSelect = "select ProductId, CategoryId, ProductName, Weight, UnitPrice, UnitslnStock from Product";
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    list.Add(new ProductObject
                    {
                        ProductID = dataReader.GetInt32(0),
                        CategoryID = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return list;
        }

        //Singleton Pattern
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public ProductObject GetProductByID(int productID)
        {
            ProductObject pro = null;
            IDataReader dataReader = null;
            string SQL = "select ProductId, CategoryId, ProductName, Weight, UnitPrice, UnitslnStock from Product where ProductId = @ProductID";
            try
            {
                var param = dataProvider.CreateParameter("@ProductID", 4, productID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQL, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    pro = new ProductObject
                    {
                        ProductID = dataReader.GetInt32(0),
                        CategoryID = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return pro;
        }

        public void AddNew(ProductObject product)
        {
            try
            {
                ProductObject pro = GetProductByID(product.ProductID);
                if (pro == null)
                {
                    string SQL = "INSERT INTO Product"
                        + "VALUES(@ProductID, @CategoryID, @ProductName, @Weight, @UnitPrice, @UnitsInStock)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductID", 4, product.ProductID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CategoryID", 4, product.CategoryID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 50, product.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 50, product.Weight, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 8, product.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@UnitsInStock", 4, product.UnitsInStock, DbType.Int32));
                    dataProvider.Insert(SQL, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The product is already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(ProductObject product)
        {
            try
            {
                ProductObject pro = GetProductByID(product.ProductID);
                if (pro != null)
                {
                    string SQL = "Update Product set CategoryId = @CategoryID, ProductName = @ProductName, Weight = @Weight, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock where ProductId = @ProductID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@ProductID", 4, product.ProductID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CategoryID", 4, product.CategoryID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@ProductName", 50, product.ProductName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Weight", 50, product.Weight, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@UnitPrice", 4, product.UnitPrice, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@UnitInStock", 4, product.UnitsInStock, DbType.Int32));
                    dataProvider.Update(SQL, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The product does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Remove(int productID)
        {
            try
            {
                ProductObject pro = GetProductByID(productID);
                if (pro != null)
                {
                    string SQL = "Delete Product where ProductId = @ProductId";
                    var param = dataProvider.CreateParameter("@ProductId", 4, productID, DbType.Int32);
                    dataProvider.Delete(SQL, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The product does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<ProductObject> SearchByNameOrID(string searchValue)
        {
            List<ProductObject> list = GetProducts();
            var listAfterSearch = new List<ProductObject>();
            if (int.TryParse(searchValue, out int value))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ProductID == int.Parse(searchValue))
                    {
                        listAfterSearch.Add(list[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ProductName.Contains(searchValue))
                    {
                        listAfterSearch.Add(list[i]);
                    }
                }
            }
            return listAfterSearch;
        }

        public List<ProductObject> SearchByUnit(string searchValue)
        {
            List<ProductObject> list = GetProducts();
            var listAfterSearch = new List<ProductObject>();
            if (int.TryParse(searchValue, out int value))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].UnitPrice == decimal.Parse(searchValue) || list[i].UnitsInStock == int.Parse(searchValue))
                    {
                        listAfterSearch.Add(list[i]);
                    }
                }
            }
            return listAfterSearch;
        }
    }
}
