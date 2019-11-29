using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wallpaper.DataEntity;

namespace Wallpaper
{
    public class MyBookDB : DbContext
    {
        public DbSet<User> User { get { return Set<User>(); } }
        public DbSet<DiaryContent> DiaryContent { get { return Set<DiaryContent>(); } }

        public MyBookDB() : base("dbConn")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfiguration.Configure(modelBuilder);
            var init = new SqliteCreateDatabaseIfNotExists<MyBookDB>(modelBuilder);
            Database.SetInitializer(init);
        }

    }
    public class ModelConfiguration
    {
        public static void Configure(DbModelBuilder modelBuilder)
        {
            ConfigureBookEntity(modelBuilder);
        }
        private static void ConfigureBookEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiaryContent>();
            modelBuilder.Entity<User>();
        }
    }
}


