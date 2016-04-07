using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities

{
    public partial class store
    {
        public store()
        {
            this.products = new List<product>();
            this.events = new List<Event>();
        }

        public int idStroe { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> openingDay { get; set; }
        public string status { get; set; }
        public string tel { get; set; }
        public Nullable<int> category_fk { get; set; }
        public Nullable<int> idUser { get; set; }
        public virtual category category { get; set; }
        public virtual ICollection<product> products { get; set; }
        public virtual user user { get; set; }
        public virtual ICollection<Event> events { get; set; }
    }
}
