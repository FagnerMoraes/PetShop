using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShop.Domain.Entities;

namespace PetShop.Domain.Interfaces.Repositories
{
    public interface IDonoRepository
    {
        Task<IEnumerable<Dono>> ObterTodosAsync();
    }
}