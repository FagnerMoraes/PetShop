using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShop.Data.Context;
using PetShop.Domain.Interfaces.Repositories;

namespace PetShop.Data.Repositories
{
    public class CareProcedureRepository : ICareProceduresRepository
    {
        private readonly PSContext _context;

        public CareProcedureRepository(PSContext context)
        {
            _context = context;
        }
    }
}