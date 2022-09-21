using System;
using Exercicio_Enumeracao_Composicao_3.Entities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Enumeracao_Composicao_3.Entities
{
    internal class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status {get; set;}
        public Client Client { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();

        public Order()
        {

        }
        public Order(DateTime date, OrderStatus status, Client client, List<OrderItem> orderItem)
        {
            Date = date;
            Status = status;
            Client = client;
            OrderItem = orderItem;
        }

        public void AddItem(OrderItem item)
        {
            OrderItem.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            OrderItem.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach(OrderItem item in OrderItem)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder orderSummary = new StringBuilder();
            orderSummary.AppendLine($"Order moment: {Date}");
            orderSummary.AppendLine($"Order status: {Status}");
            orderSummary.AppendLine($"Client: {Client.Name} ({Client.BirthDate} - {Client.Email})");
            orderSummary.AppendLine($"Order items:");
            foreach(OrderItem item in OrderItem)
            {
                orderSummary.AppendLine($"{item.Product.Name}, ${item.Price}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal().ToString("F2")}");
            }
            orderSummary.AppendLine($"Total price: ${Total()}");

            return orderSummary.ToString();
        }
    }
}
