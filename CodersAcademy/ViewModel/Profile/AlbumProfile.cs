using CodersAcademy.Api.Model;
using CodersAcademy.Api.ViewModel.Request;

namespace CodersAcademy.Api.ViewModel.Profile
{
    public class AlbumProfile : AutoMapper.Profile
    {
        public AlbumProfile ()
        {
            CreateMap<AlbumRequest, Album>();
            CreateMap<MusicRequest, Music>();
        }

    }
}
