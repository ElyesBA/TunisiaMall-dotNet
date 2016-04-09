using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TunisiaMall.Domain.Entities
{
    public partial class user: IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<user> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public user()
        {
            this.comments = new List<comment>();
            this.complaints = new List<complaint>();
            this.sentFriendRequests = new List<friendship>();
            this.friendRequests = new List<friendship>();
            this.gestbookentries = new List<gestbookentry>();
            this.recivedMessages = new List<message>();
            this.sentMessages = new List<message>();
            this.orders = new List<order>();
            this.posts = new List<post>();
            this.stores = new List<store>();
            this.subscriptions = new List<subscription>();
        }

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
        public virtual ICollection<friendship> sentFriendRequests { get; set; }
        public virtual ICollection<friendship> friendRequests { get; set; }
        public virtual ICollection<gestbookentry> gestbookentries { get; set; }
        public virtual ICollection<message> recivedMessages { get; set; }
        public virtual ICollection<message> sentMessages { get; set; }
        public virtual ICollection<order> orders { get; set; }
        public virtual ICollection<post> posts { get; set; }
        public virtual ICollection<store> stores { get; set; }
        public virtual ICollection<subscription> subscriptions { get; set; }
    }
}
