using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Repositories
{
    public class CustomerRepository
    {
        private RestaurantDBEntities ObjRestaurantDBEntities;
        public CustomerRepository()
        {
            ObjRestaurantDBEntities = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            var objSelectListItem = new List<SelectListItem>();

            objSelectListItem = (from obj in ObjRestaurantDBEntities.Customers
                                 select new SelectListItem()
                                 {
                                     Text = obj.CustomerName,
                                     Value = obj.CustomerId.ToString(),
                                     Selected = true

                                 }).ToList();

            return objSelectListItem;
        }
    }
}