using System;
using System.Collections.Generic;
using Pedido.Entities.Enum;

namespace Pedido.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Item.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Item)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

    }
}
