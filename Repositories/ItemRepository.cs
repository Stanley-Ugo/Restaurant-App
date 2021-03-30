using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Repositories
{
    public class ItemRepository
    {
        private RestaurantDBEntities ObjRestaurantDBEntities;
        public ItemRepository()
        {
            ObjRestaurantDBEntities = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllItems()
        {
            var objSelectListItem = new List<SelectListItem>();

            objSelectListItem = (from obj in ObjRestaurantDBEntities.Items
                                 select new SelectListItem()
                                 {
                                     Text = obj.ItemName,
                                     Value = obj.ItemId.ToString(),
                                     Selected = true

                                 }).ToList();

            return objSelectListItem;
        }
    }
}