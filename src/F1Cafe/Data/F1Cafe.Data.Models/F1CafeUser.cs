using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace F1Cafe.Data.Models
{
    public class F1CafeUser : IdentityUser
    {
        public F1CafeUser()
        {
            this.Orders = new HashSet<Order>();

            this.News = new HashSet<News>();

            this.Comments = new HashSet<Comment>();
        }

        public ICollection<Order> Orders { get; set; }

        public ICollection<News> News { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
