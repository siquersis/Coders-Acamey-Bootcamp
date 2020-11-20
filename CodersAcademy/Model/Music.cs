using System;


namespace CodersAcademy.Api.Model
{
    public class Music
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public int Duration { get; set; }

        public Album Album { get; set; }
    }
}
