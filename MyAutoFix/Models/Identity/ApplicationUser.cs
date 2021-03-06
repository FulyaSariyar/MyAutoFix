using Microsoft.AspNetCore.Identity;
using MyAutoFix.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAutoFix.Models.Identity
{
    public class ApplicationUser:IdentityUser
    {
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;

        public virtual List<Address> Addresses { get; set; }

        //public virtual List<Subscription> Subscriptions { get; set; }
    }
}
