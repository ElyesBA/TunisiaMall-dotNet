using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class message
    {
        public int idMessage { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string text { get; set; }
        public Nullable<int> idUserReciver_fk { get; set; }
        public Nullable<int> idUserSender_FK { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
