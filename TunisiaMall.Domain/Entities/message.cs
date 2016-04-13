using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class message
    {
        public int idMessage { get; set; }
        public System.DateTime date { get; set; }
        public string text { get; set; }
        public int idUserReciver_fk { get; set; }
        public int idUserSender_FK { get; set; }
        public user reciver { get; set; }
        public user sender { get; set; }
    }
}
