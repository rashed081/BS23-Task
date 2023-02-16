using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS23_TASk
{
    public class OrderDetail
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public OrderDetail(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }

}
