using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class subscription
    {
        public int idEvent { get; set; }
        public int idSubscription { get; set; }
        public int idUser { get; set; }
        public virtual Event eventt { get; set; }
        public virtual user user { get; set; }
    }
}
