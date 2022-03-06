using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    class OrderRepositoy : IOrderRepository
    {
        public void DeleteOrder(int orderID)
        {
            throw new NotImplementedException();
        }

        public OrderObject GetOrderByID(int orderID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderObject> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void InsertOrder(OrderObject order)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(int orderID)
        {
            throw new NotImplementedException();
        }
    }
}
