using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class guestbookentry
    {

        public guestbookentry()
        {
            this.dateEntrie = DateTime.Now.Date;
            this.rating = 0;
        }


        public int idEntries { get; set; }
        public Nullable<System.DateTime> dateEntrie { get; set; }
        public int rating { get; set; }
        public string text { get; set; }
        public int? idUser { get; set; }
        public user user { get; set; }
    }
}
