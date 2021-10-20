using System;
using System.Collections.Generic;
using System.Text;

namespace AtlanticoAPI.Infrastructure.Data.Persistence.Context
{
    public class ApiDbContext : IdentityDbContext
    {

        #region COURSES
        public DbSet<Course> Courses { get; set; }
        #endregion

        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CourseConfiguration());

        }

    }
}
