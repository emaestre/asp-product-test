using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Modelo;

namespace DataAccessLayer
{
    public class OrderDAL
    {
        TestProductDBEntities dataBase = new TestProductDBEntities();

        public List<Order> GetOrderList()
        {
            var orders = dataBase.Order.ToList();
            return orders;
        }

        public void CreateNewOrder(Order newOrder)
        {
            dataBase.Order.Add(newOrder);
            dataBase.SaveChanges();
        }

        public Order GetOrderByID(string id)
        {
            Order order = dataBase.Order.Find(id);
            return order;
        }

        public void UpdateOrder(Order order)
        {
            dataBase.Entry(order).State = System.Data.Entity.EntityState.Modified;
            dataBase.SaveChanges();
        }

        public void DeleteOrderByID(string id)
        {
            var order = dataBase.Order.Find(id);
            dataBase.Order.Remove(order);
            dataBase.SaveChanges();
        }
    }
}
