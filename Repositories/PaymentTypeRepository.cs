using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Repositories
{
    public class PaymentTypeRepository
    {
        private RestaurantDBEntities ObjRestaurantDBEntities;
        public PaymentTypeRepository()
        {
            ObjRestaurantDBEntities = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            var objSelectListItem = new List<SelectListItem>();

            objSelectListItem = (from obj in ObjRestaurantDBEntities.PaymentTypes
                                 select new SelectListItem()
                                 {
                                     Text = obj.PaymentTypeName,
                                     Value = obj.PaymentTypeId.ToString(),
                                     Selected = true

                                 }).ToList();

            return objSelectListItem;
        }
    }
}