using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.WPF.db
{
    public class WritingsDbContext : DbContext
    {
        public DbSet<ChAssessment> ChAssessments { get; set; }
        public DbSet<EngAssessment> EngAssessments { get; set; }
        public DbSet<StrokeData> StrokeDatas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            string folder = @"fypdb";
            string db = @"test.db";
            string mydocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string finalpath = Path.Combine(mydocument, folder, db);
            Debug.WriteLine("Data Source = " + finalpath);
            optionsBuilder.UseSqlite("Data Source = " + finalpath);
        }
    }
}
