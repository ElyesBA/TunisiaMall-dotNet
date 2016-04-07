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
        public int rating { get; set; }
        public Nullable<int> idUser { get; set; }
        public virtual ICollection<comment> comments { get; set; }
        public virtual user user { get; set; }
    }
}
