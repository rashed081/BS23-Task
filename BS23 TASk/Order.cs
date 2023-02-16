using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS23_TASk
{
    public class Order
    {
        public List<OrderDetail> OrderDetails { get; set; }
        public decimal TotalCost { get; set; }

        public Order(List<OrderDetail> orderDetails, decimal totalCost)
        {
            OrderDetails = orderDetails;
            TotalCost = totalCost;
        }
    }

}
