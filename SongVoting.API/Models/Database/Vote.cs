using System;

namespace SongVoting.API.Models.Database
{
    public class Vote : DatabaseTable
    {
        public int SongId { get; set; }

        public int UserId { get; set; }

        public bool Liked { get; set; }

        public DateTime Created { get; set; }
    }
}
