using Animals.Core.Domain.Owners.Models;

namespace Animals.Core.Domain.Owners.Common;

public interface IOwnersRepository
{
    void Add(Owner owner);
    void Delete(object owner);
    Task<Owner> GetOwnerById(Guid ownerId, CancellationToken cancellationToken);
    Task<Owner> GetByIdOrDefoult(Guid Id, CancellationToken cancellationToken);
}