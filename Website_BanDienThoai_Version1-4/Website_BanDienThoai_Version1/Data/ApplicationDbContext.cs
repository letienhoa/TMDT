using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website_BanDienThoai_Version1.Models;

namespace Website_BanDienThoai_Version1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<SpecialTag> SpecialTag { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<ProductSelectedForAppointment> ProductSelectedForAppointment { get; set; }
        public virtual DbSet<Nhanvien> Nhanvien { get; set; }

    }
}
