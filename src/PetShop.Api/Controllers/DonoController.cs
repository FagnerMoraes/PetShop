using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShop.Domain.Entities;
using PetShop.Domain.Interfaces.Repositories;

namespace PetShop.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DonoController : ControllerBase
    {
        private readonly IDonoRepository _donoRepository;

        public DonoController(IDonoRepository donoRepository)
        {
            _donoRepository = donoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dono>>> ObterTodos(){
            var donos = (object)await _donoRepository.ObterTodosAsync();
            return Ok(donos);
        }

    }
}