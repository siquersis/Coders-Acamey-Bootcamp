using CodersAcademy.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodersAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private AlbumRepository Repository { get; init; }

        public AlbumController(AlbumRepository repository)
        {
            this.Repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAlbuns ()
        {
            return Ok(await this.Repository.GetAllAsync());
        }
    }
}
