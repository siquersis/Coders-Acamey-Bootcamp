using System;
using System.Text.Json.Serialization;

namespace CodersAcademy.Api.Model
{
    public class Music
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public int Duration { get; set; }

        [JsonIgnore]
        public Album Album { get; set; }
    }
}
