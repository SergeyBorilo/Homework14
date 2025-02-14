
namespace Animals.Infrastructure.Application.Domain.Animals
{
    internal class Application
    {
        internal class Domain
        {
            internal class Animals
            {
                internal class Queries
                {
                    internal class GetAnimals
                    {
                        internal class OwnerDto
                        {
                            private Guid id;
                            private string firstName;
                            private string lastName;
                            private string? middleName;
                            private string email;
                            private string phoneNumber;

                            public OwnerDto(Guid id, string firstName, string lastName, string? middleName, string email, string phoneNumber)
                            {
                                this.id = id;
                                this.firstName = firstName;
                                this.lastName = lastName;
                                this.middleName = middleName;
                                this.email = email;
                                this.phoneNumber = phoneNumber;
                            }
                        }
                    }
                }
            }
        }
    }
}