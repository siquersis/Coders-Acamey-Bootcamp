using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodersAcademy.Api.ViewModel.Request
{
    public class AlbumRequest : IValidatableObject
    {
        [Required]
        public String Name { get; set; }

        [Required]
        public String Band { get; set; }

        [Required]
        public String Description { get; set; }

        [Required]
        public String Backdrop { get; set; }

        [Required]
        public IList<MusicRequest> Musics { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();

            //VALIDA SE A MÚSICA NÃO É NULA
            if (this.Musics == null)
                yield return new ValidationResult("Album must contain at least one music!");
            else
            {
                //VALIDA SE O OBJETO MÚSICA TEM PELOMENOS UMA MUSICA
                if (this.Musics == null)
                    yield return new ValidationResult("Album must contain at least one music!");

                //VALIDA ITEM A ITEM DO OBJETO MUSICA
                foreach (var item in this.Musics)
                    yield return result.First();
            }
        }
    }
}
