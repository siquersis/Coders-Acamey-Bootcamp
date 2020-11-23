using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodersAcademy.Api.ViewModel.Request
{
    public class SignInRequest
    {
        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        public String Password { get; set; }
    }
}
