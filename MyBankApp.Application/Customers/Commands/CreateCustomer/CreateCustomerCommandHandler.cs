using MediatR;
using MyBankApp.Domain.Entities;

public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Guid>
{
    public async Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var customer = new Customer(request.FullName, request.Email, request.DateOfBirth);
        // Simulate persistence
        return await Task.FromResult(customer.Id);
    }
}
