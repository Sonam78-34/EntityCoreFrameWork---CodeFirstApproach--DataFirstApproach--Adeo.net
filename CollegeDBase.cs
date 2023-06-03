using EntityCoreFrameworkCodeFirstApproach.ListColumn;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCoreFrameworkCodeFirstApproach.Data
{
    public class CollegeDBase:DbContext
    {
        public DbSet<StudentDepartment> studentDepartment { get; set; } = null!;

        public DbSet<StudentDetails> StudentsDetails { get; set; } = null!; 
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =LAPTOP-4VOKUM5G\SQLEXPRESS01; Initial Catalog=CollegeDB; Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
