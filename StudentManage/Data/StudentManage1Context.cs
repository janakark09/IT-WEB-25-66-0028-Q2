using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentManage.Models;

namespace StudentManage.Models
{
    public class StudentManage1Context : DbContext
    {
        public StudentManage1Context (DbContextOptions<StudentManage1Context> options)
            : base(options)
        {
        }

        public DbSet<StudentManage.Models.Students> Students { get; set; }

        public DbSet<StudentManage.Models.Cources> Cources { get; set; }
    }
}
