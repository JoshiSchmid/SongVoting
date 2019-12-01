using Microsoft.EntityFrameworkCore;

namespace SongVoting.API.Models.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpotifyTrack>().HasData(
                new SpotifyTrack { Id = 1, SpotifyId = "3KTikFVuiStwKvcIW0Y0uJ" },  //Gr��er 
                new SpotifyTrack { Id = 2, SpotifyId = "5vMzNmHm2ec2zrqiYhkQzZ" },  //Yes I Will
                new SpotifyTrack { Id = 3, SpotifyId = "0rH0mprtecH3grD9HFM5AD" },  //Reckless Love
                new SpotifyTrack { Id = 4, SpotifyId = "4G29gmjS7Z2nEFeM7FA6wx" },  //Voice Of Truth
                new SpotifyTrack { Id = 5, SpotifyId = "1Yqj7oGrttZH3JX2RYTmzS" },  //Du bist gut
                new SpotifyTrack { Id = 6, SpotifyId = "5Bp8uC0h4CjxENVBnahOkD" },  //Der Einzige
                new SpotifyTrack { Id = 7, SpotifyId = "2a1aibn4UgSkeTaxJSWw1L" },  //Mit dir an meiner Seite
                new SpotifyTrack { Id = 8, SpotifyId = "78twEEzRCHmOzgRn7wAl8I" },  //H�her
                new SpotifyTrack { Id = 9, SpotifyId = "7mj5fT0Biju5jR41m9ghUl" },  //King of My Heart
                new SpotifyTrack { Id = 10, SpotifyId = "5AcdaSVQfLcUKMaqchfBie" }, //My Lighthouse
                new SpotifyTrack { Id = 11, SpotifyId = "5lubagonZYGdyrfbBsOYdy" }, //Mit allem was ich bin
                new SpotifyTrack { Id = 12, SpotifyId = "5HWBaiVcqnaUf3BI4tfYG5" }, //From the Inside out
                new SpotifyTrack { Id = 13, SpotifyId = "0pvGqtwpBePPYdEVzdtXWe" }, //Wo ich auch stehe
                new SpotifyTrack { Id = 14, SpotifyId = "3i65fj9NX9PPNTDKyhlWvP" }, //Mutig komm ich vor den Thron
                new SpotifyTrack { Id = 15, SpotifyId = "4EiKZxDgW0sbT8BZ9Gl6dC" }, //What a beautiful Name
                new SpotifyTrack { Id = 16, SpotifyId = "6Nenm0bjHwjCbTet7Zb9VH" }, //From the Day
                new SpotifyTrack { Id = 17, SpotifyId = "0gI1wucmc2djSV3e25LqCd" }, //Blessings
                new SpotifyTrack { Id = 18, SpotifyId = "5SDcksP8En1l6RtTY1wzHc" }, //Oceans
                new SpotifyTrack { Id = 19, SpotifyId = "0jxIbgW2FoPhqgTh5qhegg" }, //Wunderbarer Gott
                new SpotifyTrack { Id = 20, SpotifyId = "3agx8NSEa7IPUxvbQs5Xax" }, //Ich tauch ein
                new SpotifyTrack { Id = 21, SpotifyId = "50lW1fKoDtyKaiR2bR7ksl" }  //Who You Say I Am
            );
        }

        public DbSet<SpotifyTrack> SpotifyTracks { get; set; }

        public DbSet<Vote> Votes { get; set; }
    }
}
