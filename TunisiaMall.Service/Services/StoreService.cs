﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Data.Infrastructure;
using TunisiaMall.Domain.Entities;
using TunisiaMall.Service.Pattern;

namespace TunisiaMall.Service
{
    public class StoreService: Service<store> , IStoreService 
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork utfk = new UnitOfWork(dbf);

        public StoreService() : base(utfk){ }

        //ok
        public IEnumerable<store> GetStoreByCategory(string cat)
        {
            var r = from st in dbf.DataContext.stores
                    where st.category.libelle.Equals(cat)
                    select st;
            return r;
            //return utfk.getRepository<store>().GetMany(x => x.category.libelle == categoryName);
       
        }

        //ok
        public IEnumerable<store> GetAllStores()
        {
            return utfk.getRepository<store>().GetMany();
        }

        //ok
        public IEnumerable<store> GetStoreBySubCategory(string subcategoryName)
        {
            var categ = from subcategory in dbf.DataContext.subcategories
                        where subcategory.libelle == subcategoryName
                        select subcategory.category;
          return GetStoreByCategory(categ.FirstOrDefault().libelle);
               
        }

        public IEnumerable<store> GetStoreByPromotionProduct()
        {
            var res = from product in dbf.DataContext.products
                      where product.promotion.state == true
                      select product.store;
            return res;
        }

        public IEnumerable<store> GetStoreByEvent(string titleEvent)
        {
            var res = from eventt in dbf.DataContext.events
                      where eventt.titleEvent == titleEvent
                      select eventt.stores;
            return (IEnumerable<store>)res;
        }


        // ok 
        public store GetStore(long id)
        {
           return  utfk.getRepository<store>().FindById(id);
        }


        // ok 
        public store GetStoreByName(string nom)
        {
            var res = from store in dbf.DataContext.stores
                      where store.name == nom
                      select store;
            return res.FirstOrDefault();
        }
        


    }
}
