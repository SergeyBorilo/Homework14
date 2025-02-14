namespace Animals.Application.Domain.Animals.Queries.GetAnimals;

public record OwnerDto
{
    public string phoneNumber;

    public Guid Id { get; init; }

    public string FirstName { get; init; }

    public string LastName { get; init; }

    public string? MiddleName { get; set; }

    public string Email { get; init; }

    public string PhoneNumber { get; init; }
}