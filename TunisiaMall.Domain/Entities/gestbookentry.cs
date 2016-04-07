using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class gestbookentry
    {
        public int idEntries { get; set; }
        public Nullable<System.DateTime> dateEntrie { get; set; }
        public int rating { get; set; }
        public string text { get; set; }
        public Nullable<int> user_idUser { get; set; }
        public virtual user user { get; set; }
    }
}
