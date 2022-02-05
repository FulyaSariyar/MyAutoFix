using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyAutoFix.Models.Identity;

namespace MyAutoFix.Data
{
    public class MyContext : IdentityDbContext<ApplicationUser, AplicationRole, string> //varsayılan ıd tipi string guid
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {

        }
    }
}
