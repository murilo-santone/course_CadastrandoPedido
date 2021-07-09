using System;
using System.Globalization;

namespace Pedido.Entities
{
    class OrderItem
    {
        public int Quantidade { get; set; }
        public Product Product { get; set; }



        public OrderItem()
        {

        }

        public OrderItem(int quantidade, Product product)
        {
            Quantidade = quantidade;
            Product = product;
        }


        public double SubTotal()
        {
            return Quantidade * Product.Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Product.Price}, Quantity: {Quantidade}, Subtotal: ${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
