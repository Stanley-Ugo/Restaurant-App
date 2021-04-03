using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApp.ViewModel
{
    public class OrderDetailViewModel
    {
        public int OrderId { get; set; }
        public int PaymemtTypeId { get; set; }
        public int CustomerId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal FinalTotal { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public int ItemId { get; internal set; }
        public decimal Total { get; internal set; }
        public decimal UnitPrice { get; internal set; }
    }
}