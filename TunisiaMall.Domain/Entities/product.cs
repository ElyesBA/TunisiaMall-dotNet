using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class product
    {
        public product()
        {
            this.images = new List<image>();
            this.mvtstocks = new List<mvtstock>();
            this.orderlines = new List<orderline>();
        }

        public int idProduct { get; set; }
        public double buyPrice { get; set; }
        public int criticalZone { get; set; }
        public Nullable<System.DateTime> expDate { get; set; }
        public string libelle { get; set; }
        public int qte { get; set; }
        public double sellPrice { get; set; }
        public string state { get; set; }
        public string tag { get; set; }
        public double tax { get; set; }
        public Nullable<long> Promotion_idPromotion { get; set; }
        public Nullable<int> IdPromotionSuggest_fk { get; set; }
        public Nullable<int> IdStore { get; set; }
        public Nullable<int> IdSubCategory { get; set; }
        public virtual ICollection<image> images { get; set; }
        public virtual ICollection<mvtstock> mvtstocks { get; set; }
        public virtual ICollection<orderline> orderlines { get; set; }
        public virtual store store { get; set; }
        public virtual promotionsuggest promotionsuggest { get; set; }
        public virtual promotion promotion { get; set; }
        public virtual subcategory subcategory { get; set; }
    }
}
