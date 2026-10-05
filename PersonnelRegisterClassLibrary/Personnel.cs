using PersonnelRegisterClassLibrary.Interfaces;

namespace PersonnelRegisterClassLibrary
{
    public class Personnel(Guid id) : IPersonnel
    {
        public Personnel(Guid id, string firstName, string middleName, string lastName, decimal salary) : this(Guid.NewGuid())
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Salary = salary;
        }

        public Guid Id { get; } = id;

        public string FirstName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public decimal Salary { get; set; } = 0.0M;
    }
}
