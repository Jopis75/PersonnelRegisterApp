using PersonnelRegisterClassLibrary.Interfaces;

namespace PersonnelRegisterClassLibrary
{
    public class Personnel(Guid id) : IPersonnel
    {
        public Guid Id { get; } = id;

        public string FirstName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public decimal Salary { get; set; } = 0.0M;
    }
}
