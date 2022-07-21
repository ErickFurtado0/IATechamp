using IATechamp.Models;
using Microsoft.EntityFrameworkCore;

namespace IATechamp.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<PlayerModel> Player { get; set; }
        public DbSet<ScoreboardModel> Scoreboard { get; set; }
        public DbSet<RankingModel> Ranking { get; set; }
        public DbSet<EventModel> Event { get; set; }
        public DbSet<ChampionshipModel> Championship { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);

       //     modelBuilder
       //.Entity<ScoreboardModel>(
       //    eb =>
       //    {
       //        eb.HasKey(v => v.IdScoreboard);
       //        eb.Property(v => v.GamePoints).HasColumnName("Score");
       //    });


            modelBuilder
       .Entity<PlayerModel>(
           eb =>
           {
               eb.HasKey(v => v.IdPlayer);
               eb.Property(v => v.NamePlayer).HasColumnName("Player");
           });

            modelBuilder
       .Entity<EventModel>(
           eb =>
           {
               eb.HasKey(v => v.IdEvent);
               eb.Property(v => v.DateEvent).HasColumnName("Event");
           });

            modelBuilder
      .Entity<ChampionshipModel>(
          eb =>
          {
              eb.HasKey(v => v.IdChampionship);
              eb.Property(v => v.NameChampionship).HasColumnName("Championship");
          });

        }

    }
}