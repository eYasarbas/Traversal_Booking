﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-O5D1DR7;database=TraversalDB;integrated security=true;Encrypt=False;");
        }

        #region DBSet include
        DbSet<About> Abouts { get; set; }
        DbSet<About2> Abouts2 { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Destination> Destinations { get; set; }
        DbSet<Feature> Features { get; set; }
        DbSet<Feature2> Features2 { get; set; }
        DbSet<Guide> Guides { get; set; }
        DbSet<NewsLetter> NewsLetter { get; set; }
        DbSet<SubAbout> SubAbout { get; set; }
        DbSet<Testimonal> Tests { get; set; }

        #endregion
    }

}