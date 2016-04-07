using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class category
    {
        public category()
        {
            this.subcategories = new List<subcategory>();
            this.shoprequests = new List<shoprequest>();
            this.stores = new List<store>();
        }

        public int idCategory { get; set; }
        public string description { get; set; }
        public string libelle { get; set; }
        public virtual ICollection<subcategory> subcategories { get; set; }
        public virtual ICollection<shoprequest> shoprequests { get; set; }
        public virtual ICollection<store> stores { get; set; }
    }
}
