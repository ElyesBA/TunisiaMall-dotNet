using System;
using System.Collections.Generic;

namespace TunisiaMall.Domain.Entities
{
    public partial class user
    {
        public user()
        {
            this.comments = new List<comment>();
            this.complaints = new List<complaint>();
            this.friendships = new List<friendship>();
            this.friendships1 = new List<friendship>();
            this.gestbookentries = new List<gestbookentry>();
            this.messages = new List<message>();
            this.messages1 = new List<message>();
            this.orders = new List<order>();
            this.posts = new List<post>();
            this.stores = new List<store>();
            this.subscriptions = new List<subscription>();
        }

        public string USER_TYPE { get; set; }
        public int idUser { get; set; }
        public string address { get; set; }
        public Nullable<bool> baned { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public string firstName { get; set; }
        public string gender { get; set; }
        public string job { get; set; }
        public string lastName { get; set; }
        public string login { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string pictureUrl { get; set; }






        public virtual ICollection<comment> comments { get; set; }
        public virtual ICollection<complaint> complaints { get; set; }
        public virtual ICollection<friendship> friendships { get; set; }
        public virtual ICollection<friendship> friendships1 { get; set; }
        public virtual ICollection<gestbookentry> gestbookentries { get; set; }
        public virtual ICollection<message> messages { get; set; }
        public virtual ICollection<message> messages1 { get; set; }
        public virtual ICollection<order> orders { get; set; }
        public virtual ICollection<post> posts { get; set; }
        public virtual ICollection<store> stores { get; set; }
        public virtual ICollection<subscription> subscriptions { get; set; }
    }
}
