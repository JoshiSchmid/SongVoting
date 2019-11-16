using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SongVoting.API.Models.Database;

namespace SongVoting.API.Controllers
{
    [Route("api/songs")]
    public class SongController : ControllerBase
    {
        public SongController()
        {

        }

        [HttpGet]
        public Song[] GetSongs()
        {
            return new[] {
                new Song
                {
                    SongId = "3BQ4q1bmonEIteIrlt1zxm"
                },
                new Song
                {
                    SongId = "4UPk6n78h6dHxEgIx0Lxh3"
                },
                new Song
                {
                    SongId = "0JO1CEUuyozopyTLPEMmhj"
                },
                new Song
                {
                    SongId = "1UCJecpXZ6mSReWOoHq8t7"
                },
                new Song
                {
                    SongId = "7HsjQDosSNy6qr1IFhUsXe"
                }
            };
        }

        [HttpPost("{songId}")]
        public void LikeSong(string songId, [FromBody] bool? liked)
        {

        }
    }
}
