using _5Layers.Animals.Persistence.EFCore.AnimalsDb;
using Animals.Application.Domain.Owners.Queries.GetOwnersDetails;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Animals.Infrastructure.Application.Domain.Owners.Queries.GetOwnersDetails
{
    public class GetOwnersDetailsQueryHandler(AnimalsDbContext dbContext) : IRequestHandler<GetOwnerDetailsQuery, OwnerDetailsDto>
    {
        public async Task<OwnerDetailsDto> Handle(
            GetOwnerDetailsQuery query,
            CancellationToken cancellationToken)
        {
            var owner = await dbContext
                       .Owners
                       .AsNoTracking()
                       .FirstOrDefaultAsync(x => x.Id == query.Id, cancellationToken)
                   ?? throw new ArgumentException($"Owner with id: {query.Id} was not found.", nameof(query.Id));

            return new OwnerDetailsDto(
                owner.Id,
                owner.FirstName,
                owner.LastName,
                owner.MiddleName,
                owner.Email,
                owner.PhoneNumber);

        }      
    }
}
