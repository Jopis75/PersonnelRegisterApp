namespace PersonnelRegisterClassLibrary.Interfaces
{
    public interface IPersonnelRegister
    {
        int PersonnelCount { get; }

        bool AddPersonnel(Personnel personnel);

        bool RemovePersonnel(Guid id);

        Personnel FindPersonnel(Guid id);

        void PrintPersonnel(Personnel personnel);

        void PrintPersonnelList();
    }
}
