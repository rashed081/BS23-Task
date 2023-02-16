using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS23_TASk
{
    public class ShoppingCart
    {
        private Dictionary<Product, int> _items;

        public ShoppingCart()
        {
            _items = new Dictionary<Product, int>();
        }

        public void AddItem(Product product, int quantity)
        {
            if (_items.ContainsKey(product))
            {
                _items[product] += quantity;
            }
            else
            {
                _items.Add(product, quantity);
            }
        }

        public void RemoveItem(Product product, int quantity)
        {
            if (_items.ContainsKey(product))
            {
                if (_items[product] <= quantity)
                {
                    _items.Remove(product);
                }
                else
                {
                    _items[product] -= quantity;
                }
            }
        }

        public decimal GetTotalCost()
        {
            decimal total = 0;
            foreach (var item in _items)
            {
                total += item.Key.Price * item.Value;
            }
            return total;
        }
    }

}
