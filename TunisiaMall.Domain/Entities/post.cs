using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class post
    {
        public post()
        {
            this.comments = new List<comment>();
        }

        public int idPost { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public Nullable<int> rating { get; set; }
        public DateTime postDate { get; set; }
        public int idUser { get; set; }
        public virtual ICollection<comment> comments { get; set; }
        public virtual user user { get; set; }
    }
}
