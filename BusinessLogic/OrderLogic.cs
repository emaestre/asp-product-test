using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Modelo;

namespace BusinessLogic
{
    public class OrderLogic
    {
        OrderDAL dataAccess = new OrderDAL();
        public List<Order> GetOrderList()
        {
            var orders = dataAccess.GetOrderList();
            return orders;
        }

        public void CreateNewOrder(Order newOrder)
        {
            dataAccess.CreateNewOrder(newOrder);
        }

        public Order GetOrderByID(string id)
        {
            Order order = dataAccess.GetOrderByID(id);
            return order;
        }

        public void UpdateProduct(Order order)
        {
            dataAccess.UpdateOrder(order);
        }

        public void DeleteOrderByID(string id)
        {
            dataAccess.DeleteOrderByID(id);
        }
    }
}
