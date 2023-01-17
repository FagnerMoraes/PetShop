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
        public async Task<ActionResult<IEnumerable<PetOwnerDTO>>> GetAll() 
        {
            var petOwners = await _donoRepository.GeAllAsync();                       
            var petOwnersDTO = petOwners.Select(petOwner => _mapper.Map<PetOwnerDTO>(petOwner));           
            return Ok(petOwnersDTO);
        }

        [HttpGet("consultar-nome")]
        public async Task<ActionResult<IEnumerable<PetOwnerDTO>>> GetByName(string name)
        {
            var petOwners = await _donoRepository.GetByNameAsync(name);
            var petOwnersDTO = petOwners.Select(dono => _mapper.Map<PetOwnerDTO>(dono));
            return Ok(petOwnersDTO);
        }

        [HttpGet("consultar-dono")]
        public async Task<ActionResult<PetOwnerDTO>> GetById(int id)
        {
            var petOwner = await _donoRepository.GetByIdAsync(id);
            var petOwnerDTO = _mapper.Map<PetOwnerDTO>(petOwner);
            if (petOwnerDTO is null)
                return NotFound("Dono nao encontrado");
            return Ok(petOwnerDTO);
        }

        [HttpPost("cadastrar")]
        public async Task<ActionResult<PetOwner>> Post([FromBody]PetOwnerDTO petOwnerDTO){
            var petOwner = _mapper.Map<PetOwner>(petOwnerDTO);
            await _donoRepository.CreateAsync(petOwner);
            var success = _donoRepository.SaveAsync();
            if (success.Result) {
                var id = petOwner.Id;
                return CreatedAtAction(nameof(GetById),new { id = id }, id);
            } else {
                _donoRepository.Dispose();
                return BadRequest("Erro ao tentar cadastrar");
            }                        
        }

    }
}