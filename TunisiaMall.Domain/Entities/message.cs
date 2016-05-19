using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class message
    {
        public int idMessage { get; set; }
        public System.DateTime date { get; set; }
        public string text { get; set; }
        public int idReceiver { get; set; }
        public int idSender { get; set; }
        public virtual user receiver { get; set; }
        public virtual user sender { get; set; }
    }
}
