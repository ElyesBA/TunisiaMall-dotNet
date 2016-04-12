using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Services;
using TunisiaMallWeb.Logic;

namespace TunisiaMallWeb.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            OrderService os = new OrderService();
            ShoppingCartActions us = new ShoppingCartActions();
            customer customer = new customer { idUser = us.getCurrentUserID() };
            List<order> orders = new List<order>();
            foreach (var item in os.getOrdersByCustomer(customer))
            {
                if (item.idu == customer.idUser) { 
                     orders=item.orders;
                     }
            }
            return View(orders);
        }
        //{
        //    customer u = new customer { idUser = 1 };
        //    // order o = new order { idUser = u.idUser, orderStatus = "pending", cardHolder = "dali" };
        //    order o = new order { idOrder = 4 };
        //    order o2 = new order { idOrder = 5 };
        //    order o3 = new order { idOrder = 10, idUser = 1 };
        //    OrderService os = new OrderService();
        //    // os.removeOrder(o);
        //    os.saveAsUnpaiedOrderOrUnpaid(o2, 1);
        //    os.saveAsUnpaiedOrderOrUnpaid(o3, 0);
        //    os.createOrder(o);
        //    os.getOrdersByCustomer(u);
        //    OrderLineService ols = new OrderLineService();
        //    product p = new product { idProduct = 1 };
        //    orderline ol6 = new orderline { idProduct_fk = p.idProduct, idOrder_fk = o2.idOrder, qte = 1 };
        //    //ok
        //    ols.addProductTOorder(ol6);
        //    ols.getOrderLinesByOrder(o2);
        //    ols.getTotalOrder(o2);
        //    ShoppingCartActions sc = new ShoppingCartActions();
        //    orderline ol = new orderline { idProduct_fk = 4, qte = 10 };
        //    orderline ol1 = new orderline { idProduct_fk = 4, qte = 30 };
        //    orderline ol2 = new orderline { idProduct_fk = 6, qte = 2 };
        //    sc.addToCart(ol);

        //    sc.addToCart(ol1);
        //    sc.addToCart(ol2);

        //    List<orderline> lis = sc.getCurrentSessionOrderLines();
        //    foreach (var item in lis)
        //    {
        //        System.Diagnostics.Debug.WriteLine("order line in session " + item.idProduct_fk + " order " + item.idOrder_fk + "qte " + item.qte);
        //    }
        //    sc.removeFromCart((int)ol.idProduct_fk);
        //    foreach (var item in lis)
        //    {
        //        System.Diagnostics.Debug.WriteLine("order line in after supression session " + item.idProduct_fk + " order " + item.idOrder_fk + "qte " + item.qte);
        //    }
        //    Console.Beep();
       
 

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
