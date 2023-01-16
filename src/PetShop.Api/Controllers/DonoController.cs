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
        [HttpGet("consultar-um-dono")]
        public async Task<ActionResult<PetOwnerDTO>> Get(int id)
        {
            var petOwner = await _donoRepository.GetById(id);
            var petOwnerDTO = _mapper.Map<PetOwnerDTO>(petOwner);
            if (petOwnerDTO is null)
                return NotFound();
            return Ok(petOwnerDTO);
        }

        [HttpGet("consultar-nome")]
        public async Task<ActionResult<IEnumerable<PetOwnerDTO>>> GetByName(string nome){
            var donos = await _donoRepository.GetByNameAsync(nome);
            var donoDTO = donos.Select(dono => _mapper.Map<PetOwnerDTO>(dono));           
            return Ok(donoDTO);
        }

        [HttpPost("cadastrar")]
        public async Task<ActionResult<PetOwner>> Post([FromBody]PetOwnerDTO petOwnerDTO){
            var petOwner = _mapper.Map<PetOwner>(petOwnerDTO);
            await _donoRepository.CreateAsync(petOwner);
            var success = _donoRepository.SaveAsync();
            if (success.Result) {
                var id = petOwner.Id;
               return CreatedAtAction(nameof(Get),new { id = id }, id);
            }  else  {
                _donoRepository.Dispose();
                return BadRequest();
            }                        
        }

    }
}