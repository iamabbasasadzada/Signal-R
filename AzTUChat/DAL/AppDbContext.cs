using AzTUChat.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
namespace AzTUChat.DAL
{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions option):base(option)
        {

        }
        public DbSet<UserImage> UserImages { get; set; }
    }
}
