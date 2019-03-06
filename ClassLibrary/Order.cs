using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Order
    {
        public Order()
        {
                
        }

        public Order(int orderId, DateTime date, Account account, List<LineItem> lineItems, OrderStatus orderStatus)
        {
            OrderId = orderId;
            Date = date;
            Account = account;
            LineItems = lineItems;
            OrderStatus = orderStatus;
        }
        public OrderStatus OrderStatus { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Account Account { get; set; }
        public List<LineItem> LineItems { get; set; } = new List<LineItem>();

        public void Add(Product product, int quantity)
        {
           // List<LineItem> lineItems = new List<LineItem>();

            LineItems.Add(new LineItem{Product = product, Quantity = quantity});
        }
    }
}
