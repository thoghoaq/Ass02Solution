using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetailObject> GetOrderDetails();
        OrderDetailObject GetOrderDetailByID(int orderDetailID);
        void InsertOrderDetail(OrderDetailObject orderDetailObject);
        void UpdateOrderDetail(int orderDetailID);
        void DeleteOrderDetail(int orderDetailID);
    }
}
