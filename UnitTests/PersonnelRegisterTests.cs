using PersonnelRegisterClassLibrary;

namespace UnitTests
{
    public class PersonnelRegisterTests
    {
        private readonly PersonnelRegister _personnelRegister;

        public PersonnelRegisterTests()
        {
            _personnelRegister = new PersonnelRegister();
        }

        [Fact]
        public void TestAddPersonnel()
        {
            // Arrange
            var personnel1 = new Personnel(Guid.NewGuid());
            var personnel2 = new Personnel(Guid.NewGuid());
            var personnel3 = new Personnel(Guid.NewGuid());

            // Act
            _personnelRegister.AddPersonnel(personnel1);
            _personnelRegister.AddPersonnel(personnel2);
            _personnelRegister.AddPersonnel(personnel3);

            // Assert
            Assert.Equal(3, _personnelRegister.PersonnelCount);
        }

        [Fact]
        public void TestRemovePersonnel()
        {
            // Arrange
            var personnel1 = new Personnel(Guid.NewGuid());
            var personnel2 = new Personnel(Guid.NewGuid());
            var personnel3 = new Personnel(Guid.NewGuid());

            _personnelRegister.AddPersonnel(personnel1);
            _personnelRegister.AddPersonnel(personnel2);
            _personnelRegister.AddPersonnel(personnel3);

            // Act
            _personnelRegister.RemovePersonnel(personnel2.Id);
            
            // Assert
            Assert.Equal(2, _personnelRegister.PersonnelCount);
        }

        [Fact]
        public void TestFindPersonnel()
        {
            // Arrange
            var personnel1 = new Personnel(Guid.NewGuid());
            var personnel2 = new Personnel(Guid.NewGuid());
            var personnel3 = new Personnel(Guid.NewGuid());

            _personnelRegister.AddPersonnel(personnel1);
            _personnelRegister.AddPersonnel(personnel2);
            _personnelRegister.AddPersonnel(personnel3);

            // Act
            var foundPersonnel = _personnelRegister.FindPersonnel(personnel2.Id);

            // Assert
            Assert.Equal(personnel2.Id, foundPersonnel.Id);
        }
    }
}
