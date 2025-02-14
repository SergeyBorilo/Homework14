using MediatR;

namespace Animals.Application.Domain.Owners.Queries.GetOwnersDetails
{
    public record GetOwnerDetailsQuery(Guid Id) : IRequest<OwnerDetailsDto>;
}