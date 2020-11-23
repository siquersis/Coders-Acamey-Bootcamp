using System;
using System.Text.Json.Serialization;

namespace CodersAcademy.Api.Model
{
    public class UserFavoriteMusic
    {

        public Guid Id { get; set; }

        public Guid MusicId { get; set; }

        public Guid UserId { get; init; }

        public Music Music { get; set; }

        [JsonIgnore]
        public User User { get; set; }
    }
}
