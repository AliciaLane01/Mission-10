using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Cart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public virtual void AddItem(Book bk, int qty)
        {
            CartItem item = Items
                .Where(x => x.Book.BookId == bk.BookId)
                .FirstOrDefault();

            if (item == null)
            {
                Items.Add(new CartItem
                {
                    Book = bk,
                    Quantity = qty
                });
            }
            else
            {
                item.Quantity += qty;
            }
        }

        public virtual void RemoveItem(Book bk)
        {
            Items.RemoveAll(x => x.Book.BookId == bk.BookId);
        }

        public virtual void ClearCart()
        {
            Items.Clear();
        }

        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);
            return sum;
        }
         
        public class CartItem
        {
            [Key]
            public int ItemID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
