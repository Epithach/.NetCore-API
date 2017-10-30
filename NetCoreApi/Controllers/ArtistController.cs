using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreApi.Controllers
{
    public enum MusicType
    {
        Pop = 0,
        Rap = 1,
        Trap = 2,
        Rock = 3,
        Metal = 4,
        Raggae = 5,
        RnB = 6
    }
    public class Artist
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        [JsonProperty(PropertyName = "fullName")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "rating")]
        public double Rating { get; set; }

        [JsonProperty(PropertyName = "musicType")]
        public List<MusicType> MusicTypeList { get; set; }
    }

    [Route("api/Artist")]
    public class ArtistController : Controller
    {
        public List<Artist> ArtistList { get; set; }

        public ArtistController()
        {
            ArtistList = new List<Artist>();

            ArtistList.Add(new Artist() { Id = 0, DisplayName = "Ed Sheeran", FullName = "Ed Sheeran", Rating = 4.9, MusicTypeList = new List<MusicType>() { MusicType.Pop } });
            ArtistList.Add(new Artist() { Id = 1, DisplayName = "Niska", FullName = "Ed Sheeran", Rating = 4.9, MusicTypeList = new List<MusicType>() { MusicType.Pop } });
            ArtistList.Add(new Artist() { Id = 2, DisplayName = "Chris Brown", FullName = "Ed Sheeran", Rating = 4.9, MusicTypeList = new List<MusicType>() { MusicType.Pop } });
            ArtistList.Add(new Artist() { Id = 3, DisplayName = "Keblack", FullName = "Ed Sheeran", Rating = 4.9, MusicTypeList = new List<MusicType>() { MusicType.Pop } });
            ArtistList.Add(new Artist() { Id = 4, DisplayName = "Eric Clapton", FullName = "Ed Sheeran", Rating = 4.9, MusicTypeList = new List<MusicType>() { MusicType.Pop } });
            ArtistList.Add(new Artist() { Id = 5, DisplayName = "Damso", FullName = "Ed Sheeran", Rating = 4.9, MusicTypeList = new List<MusicType>() { MusicType.Pop } });
            ArtistList.Add(new Artist() { Id = 6, DisplayName = "Mickael Jackson", FullName = "Ed Sheeran", Rating = 4.9, MusicTypeList = new List<MusicType>() { MusicType.Pop } });
            ArtistList.Add(new Artist() { Id = 7, DisplayName = "Jonhy Halliday", FullName = "Ed Sheeran", Rating = 4.9, MusicTypeList = new List<MusicType>() { MusicType.Pop } });
            ArtistList.Add(new Artist() { Id = 8, DisplayName = "Booba", FullName = "Ed Sheeran", Rating = 4.9, MusicTypeList = new List<MusicType>() { MusicType.Pop } });
            ArtistList.Add(new Artist() { Id = 9, DisplayName = "Fort Minor", FullName = "Ed Sheeran", Rating = 4.9, MusicTypeList = new List<MusicType>() { MusicType.Pop } });
        }

        [Route("")]
        public List<Artist> GetAll()
        {
            return this.ArtistList;
        }

        public Artist GetById(int id)
        {
            return this.ArtistList.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}
