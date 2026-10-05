namespace PersonnelRegisterClassLibrary.Interfaces
{
    public interface IPersonnel
    {
        Guid Id { get; }

        string FirstName { get; }

        string MiddleName { get; }

        string LastName { get; }

        decimal Salary { get; }
    }
}
