namespace MyBankApp.Domain.Entities;

public class Customer
{
    public Guid Id { get; private set; }
    public string FullName { get; private set; }
    public string Email { get; private set; }
    public DateOnly DateOfBirth { get; private set; }

    public Customer(string fullName, string email, DateOnly dob)
    {
        Id = Guid.NewGuid();
        FullName = fullName;
        Email = email;
        DateOfBirth = dob;
    }

    public void UpdateEmail(string newEmail)
    {
        Email = newEmail;
    }
}
