using Microsoft.EntityFrameworkCore;
using Assignment_2_form_validation_.Models;


namespace Assignment_2_form_validation_.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<FormModel> formModels { get; set; }
    }
}
