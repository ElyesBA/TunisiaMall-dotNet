using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class friendship
    {
        public int id { get; set; }
        public bool accepted { get; set; }
        public Nullable<int> idUser1 { get; set; }
        public Nullable<int> idUser2 { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
