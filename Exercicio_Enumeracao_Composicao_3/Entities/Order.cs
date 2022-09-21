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
        public OrderStatus status {get; set;}
        public Client client { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();


    }
}
