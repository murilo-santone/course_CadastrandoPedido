using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido.Entities
{
    class OrderItem
    {
        public int Quantidade { get; set; }
        public double Price { get; set; }



        public OrderItem()
        {

        }

        public OrderItem(int quantidade, double price)
        {
            Quantidade = quantidade;
            Price = price;
        }


        public double SubTotal()
        {
            return Quantidade * Price;
        }
    }
}
