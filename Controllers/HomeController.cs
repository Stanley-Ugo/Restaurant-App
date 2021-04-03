﻿using RestaurantApp.Models;
using RestaurantApp.Repositories;
using RestaurantApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Controllers
{
    public class HomeController : Controller
    {
        private RestaurantDBEntities objRestaurantDBEntities;
        public HomeController()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();
        }
        // GET: Home
        public ActionResult Index()
        {
            CustomerRepository objCustomerRepository = new CustomerRepository();

            ItemRepository objItemRepository = new ItemRepository();

            PaymentTypeRepository objPaymentTypeRepository = new PaymentTypeRepository();

            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (objCustomerRepository.GetAllCustomers(),objItemRepository.GetAllItems(), objPaymentTypeRepository.GetAllPaymentType());

            return View(objMultipleModels);
        }

        [HttpGet]
        public JsonResult getItemUnitPrice(int itemId)
        {
            decimal unitPrice = objRestaurantDBEntities.Items.Single(model => model.ItemId == itemId).ItemPrice;

            return Json(unitPrice, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Index(OrderViewModel objOrderViewModel)
        {
            OrderRepository objOrderRepository = new OrderRepository();
            objOrderRepository.AddOrder(objOrderViewModel);

            return Json("Your Order has been Successfully Placed", JsonRequestBehavior.AllowGet);
        }
    }
}