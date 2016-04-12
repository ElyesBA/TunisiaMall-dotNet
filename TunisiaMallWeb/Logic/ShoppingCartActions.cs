using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Services;

namespace TunisiaMallWeb.Logic
{
    public class ShoppingCartActions
    {
        public static List<orderline> globalList = new List<orderline>();
        public string ShoppingCartId { get; set; }
        public const string CartSessionKey = "CartId";
        public string sessionID;
        public int getCurrentUserID()
        {
            UserService us = new UserService();
            return us.getUserIdByUsername(HttpContext.Current.User.Identity.Name);
        }
        public string GetCartId()
        {
            if (HttpContext.Current.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[CartSessionKey] = HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.     
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session[CartSessionKey] = tempCartId.ToString();
                }
            }

            return HttpContext.Current.Session[CartSessionKey].ToString();
        }

        public void addToCart(orderline orderlineP)
        {
            sessionID = GetCartId();
            System.Diagnostics.Debug.WriteLine(" into cart with id : " + sessionID);
            int x = 0;
            for (int i = 0; i < globalList.Count(); i++)
            {

                if (globalList[i].idProduct_fk == orderlineP.idProduct_fk)
                {
                    globalList[i].qte = globalList[i].qte + orderlineP.qte;
                    System.Diagnostics.Debug.WriteLine(" qte finale " + globalList[i].qte);
                    x = 1;
                }

            }
            if (x == 0)
                globalList.Add(orderlineP);

            HttpContext.Current.Session[CartSessionKey] = globalList;

        }
        public List<orderline> getCurrentSessionOrderLines()
        {
            return HttpContext.Current.Session[CartSessionKey] as List<orderline>;
        }
        //this method deletes a orderline depending on the product id of the orderline
        //if the method don't get a parameter the method deletes all the orderlines of the current cart

            
        public void removeFromCart(int idprod = 0)
        {
            if (idprod != 0)
            {
                globalList.RemoveAll(c => c.idProduct_fk == idprod);
            }
            else
            {
                globalList.Clear();
            }
        }

    }
}