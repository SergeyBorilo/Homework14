using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Application.Domain.Animals.Commands.RemoveOwner;

public class RemoveOwnerCommand(Guid AnimalId, Guid OwnerId) : IRequest
{
    public Guid AnimalId { get; } = AnimalId;
    public Guid OwnerId { get; } = OwnerId;
}
   

