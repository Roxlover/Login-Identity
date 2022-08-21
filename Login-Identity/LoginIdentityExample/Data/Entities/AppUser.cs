using Microsoft.AspNetCore.Identity;
using System;

namespace LoginIdentityExample.Data.Entities
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }

        public DateTime DateModified { get; set; }

        public DateTime DateCreated { get; set; }

    }
}
