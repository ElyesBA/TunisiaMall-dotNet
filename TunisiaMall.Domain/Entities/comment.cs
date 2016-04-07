using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class comment
    {
        public int idComment { get; set; }
        public Nullable<System.DateTime> commentDate { get; set; }
        public int rating { get; set; }
        public string text { get; set; }
        public Nullable<int> idPost { get; set; }
        public Nullable<int> idUser { get; set; }
        public virtual post post { get; set; }
        public virtual user user { get; set; }
    }
}
