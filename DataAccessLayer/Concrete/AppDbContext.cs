using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

          optionsBuilder.UseSqlServer("server=DESKTOP-NF14SNF\\MSSQLSERVER01;database=proje;Integrated Security=true;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");



        }
    
        public DbSet<Adresses>Adresses { get; set; }
        public DbSet<Categories>Categories { get; set; }
        public DbSet<Companies>Companies { get; set; }
        public DbSet<Competencies>Competencies { get; set; }
        public DbSet<JobAdverts>JobAdverts { get; set; }
        public DbSet<JobApplications>JobApplications { get; set; }
        public DbSet<JobSkills> JobSkills { get; set; }
        public DbSet<JobTypes> JobTypes { get; set; }
     
        public DbSet<Users> Users { get; set; }
        public DbSet<UserSkills> UserSkills { get; set; }


    }
}
