using System;
using System.Collections.Generic;

namespace CodersAcademy.Api.Model
{
    public class Album
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        public String Backdrop { get; set; }

        public String Band { get; set; }

        public IList<Music> Musics { get; set; }
    }
}
