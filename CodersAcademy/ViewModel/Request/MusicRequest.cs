using System;
using System.ComponentModel.DataAnnotations;

namespace CodersAcademy.Api.ViewModel.Request
{
    public class MusicRequest
    {
        [Required]
        public String Name { get; set; }


        [Required]
        public int Duration { get; set; }
    }
}
