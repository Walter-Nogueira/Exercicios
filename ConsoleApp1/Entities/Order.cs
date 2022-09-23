using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Entities.Enums;

namespace ConsoleApp1.Entities
{
    internal class Order
    {
        DateTime Date { get; set; }
        OrderStatus Status { get; set; }
        Client Client { get; set; }

        List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }
        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
    }

}
