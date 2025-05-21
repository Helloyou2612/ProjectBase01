using MediatR;

public record CreateCustomerCommand(string FullName, string Email, DateOnly DateOfBirth) : IRequest<Guid>;
