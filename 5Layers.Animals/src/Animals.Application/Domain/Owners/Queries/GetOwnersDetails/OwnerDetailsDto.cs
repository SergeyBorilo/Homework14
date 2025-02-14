namespace Animals.Application.Domain.Owners.Queries.GetOwnersDetails;

public record OwnerDetailsDto(
    Guid Id, 
    string FirstName,
    string LastName,
    string? MiddleName,
    string Email,
    string PhoneNumber);