using Microsoft.EntityFrameworkCore;
using AuthAPI.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace AuthAPI.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {

        }
    }
}
