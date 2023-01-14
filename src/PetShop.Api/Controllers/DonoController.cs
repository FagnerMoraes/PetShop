using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetShop.Api.DTO;
using PetShop.Domain.Entities;
using PetShop.Domain.Interfaces.Repositories;

namespace PetShop.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DonoController : ControllerBase
    {
        private readonly IPetOwnerRepository _donoRepository;
        private readonly IMapper _mapper;

        public DonoController(IPetOwnerRepository donoRepository, IMapper mapper)
        {
            _donoRepository = donoRepository;
            _mapper = mapper;
        }

        [HttpGet("consultar-todos")]
        public async Task<ActionResult<IEnumerable<PetOwnerDTO>>> Get(){
            var petOwners = await _donoRepository.GeAllAsync();                       
            var petOwnersDTO = petOwners.Select(petOwner => _mapper.Map<PetOwnerDTO>(petOwner));           
            return Ok(petOwnersDTO);
        }

        [HttpGet("consultar-nome")]
        public async Task<ActionResult<IEnumerable<PetOwnerDTO>>> GetByName(string nome){
            var donos = await _donoRepository.GetByNameAsync(nome);
            var donoDTO = donos.Select(dono => _mapper.Map<PetOwnerDTO>(dono));           
            return Ok(donoDTO);
        }

        [HttpPost("cadastrar")]
        public async Task<ActionResult<PetOwner>> Post([FromBody]PetOwnerDTO donoDTO){
            var dono = _mapper.Map<PetOwner>(donoDTO);
            await _donoRepository.CreateAsync(dono);
            return Ok();
        }

    }
}