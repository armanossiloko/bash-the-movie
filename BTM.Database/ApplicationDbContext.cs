using BTM.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace BTM.Database
{
    public class ApplicationDbContext : DbContext//IdentityDbContext<User, Role, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UsersRoles> UserRoles { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<ActingRole> ActingRoles { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<AwardShow> AwardShows { get; set; }
        public DbSet<AwardType> AwardTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        //public DbSet<Episode> Episodes { get; set; }
        public DbSet<Image> Images { get; set; }
        //public DbSet<ImageType> ImageTypes { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<MediaUser> MediaUsers { get; set; }
        public DbSet<MPAARating> MPAARating { get; set; }
        public DbSet<People> People { get; set; }
        //public DbSet<Permission> Permissions { get; set; }
        public DbSet<PlotKeywords> PlotKeywords { get; set; }
        //public DbSet<Season> Seasons { get; set; }
        public DbSet<SetRole> SetRoles { get; set; }
        public DbSet<Soundtrack> Soundtracks { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<Genre> Genre { get; set; }

        //Many-to-Many relationships
        public DbSet<MediaLanguage> MediaLanguage { get; set; }
        public DbSet<MediaGenre> MediaGenre { get; set; }
        public DbSet<MediaCountry> MediaCountries { get; set; }
        public DbSet<MediaActingRole> MediaActingRoles { get; set; }
        public DbSet<MediaList> MediaLists { get; set; }
        public DbSet<MediaPlotKeywords> MediaPlotKeywords { get; set; }
        public DbSet<MediaPeopleSetRole> MediaPeopleSetRole { get; set; }
        //public DbSet<MediaSoundtrack> MediaSoundtracks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<MediaActingRole>().HasKey(x => new { x.MediaID, x.ActingRoleID });
            builder.Entity<MediaCountry>().HasKey(x => new { x.MediaID, x.CountryID });
            builder.Entity<MediaGenre>().HasKey(x => new { x.MediaID, x.GenreID });
            builder.Entity<MediaLanguage>().HasKey(x => new { x.MediaID, x.LanguageID });
            builder.Entity<MediaList>().HasKey(x => new { x.MediaID, x.ListID });
            builder.Entity<MediaPeopleSetRole>().HasKey(x => new { x.MediaID, x.PeopleID, x.SetRoleID });
            builder.Entity<MediaPlotKeywords>().HasKey(x => new { x.MediaID, x.KeywordID });
            //builder.Entity<MediaSoundtrack>().HasKey(x => new { x.MediaID, x.SoundtrackID });
            builder.Entity<MediaUser>().HasKey(x => new { x.MediaID, x.UserID });
        }
    }
}
