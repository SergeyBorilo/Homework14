﻿using _5Layers.Animals.Persistence.EFCore.AnimalsDb;
using Animals.Core.Domain.Owners.Common;
using Animals.Core.Domain.Owners.Models;
using Microsoft.EntityFrameworkCore;

namespace Animals.Infrastructure.Core.Domain.Owners.Common
{
    public class OwnersRepository(AnimalsDbContext dbContext) : IOwnersRepository
    {
        public async Task<Owner> GetOwnerById(Guid ownerid, CancellationToken cancellationToken)
        {
            return await dbContext
                .Owners
                .Include(x => x.Animals)
                .FirstOrDefaultAsync(x => x.Id == ownerid, cancellationToken) ?? throw new InvalidOperationException("Owner was not found");
        }


        public async Task<Owner?> GetByIdOrDefault(Guid ownerId, CancellationToken cancellationToken)
        {
            return await dbContext
                .Owners
                .FirstOrDefaultAsync(x => x.Id == ownerId, cancellationToken);
        }

        public void Add(Owner owner)
        {
            dbContext.Add(owner);
        }

        public void Delete(Owner owner)
        {
            dbContext.Remove(owner);
        }

        public void Delete(object owner)
        {
           
        }

        public Task<Owner> GetByIdOrDefoult(Guid Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
