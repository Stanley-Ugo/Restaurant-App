using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApp.Repositories
{
    public class OrderRepository
    {
        private RestaurantDBEntities objRestaurantDBEntities;
        public OrderRepository()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();
        }
    }
}