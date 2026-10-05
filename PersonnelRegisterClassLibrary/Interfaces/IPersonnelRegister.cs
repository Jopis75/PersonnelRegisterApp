namespace PersonnelRegisterClassLibrary.Interfaces
{
    public interface IPersonnelRegister
    {
        bool AddPersonnel(Personnel personnel);

        bool RemovePersonnel(Guid id);

        Personnel FindPersonnel(Guid id);

        void PrintPersonnel(Personnel personnel);

        void PrintPersonnelList();
    }
}
