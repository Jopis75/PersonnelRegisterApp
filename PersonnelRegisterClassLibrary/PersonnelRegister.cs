using PersonnelRegisterClassLibrary.Interfaces;

namespace PersonnelRegisterClassLibrary
{
    public class PersonnelRegister : IPersonnelRegister
    {
        private readonly Dictionary<Guid, Personnel> personnelDictionary = [];

        public bool AddPersonnel(Personnel personnel)
        {
            return personnelDictionary.TryAdd(personnel.Id, personnel);
        }

        public bool RemovePersonnel(Guid id)
        {
            return personnelDictionary.Remove(id);
        }

        public Personnel FindPersonnel(Guid id)
        {
            if (personnelDictionary.TryGetValue(id, out var personnel))
            {
                return personnel;
            }

            return new Personnel(Guid.Empty); // Null Object Pattern. Return an empty Personnel object if not found.
        }

        public void PrintPersonnelList()
        {
            foreach (var personnel in personnelDictionary.Values)
            {
                Console.WriteLine($"ID: {personnel.Id}");
                if (string.IsNullOrEmpty(personnel.MiddleName))
                {
                    Console.WriteLine($"Name: {personnel.FirstName} {personnel.LastName}");
                }
                else
                {
                    Console.WriteLine($"Name: {personnel.FirstName} {personnel.MiddleName} {personnel.LastName}");
                }
                Console.WriteLine($"Salary: {personnel.Salary:C}");
                Console.WriteLine();
            }
        }
    }
}
