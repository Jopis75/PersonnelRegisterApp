using PersonnelRegisterClassLibrary;

var personnelRegister = new PersonnelRegister();

var quit = false;

while (!quit)
{
    var choice = ReadMenuChoice();

    switch (choice)
    {
        case "1":
            AddPersonnel(personnelRegister);
            break;
        case "2":
            RemovePersonnel(personnelRegister);
            break;
        case "3":
            FindPersonnel(personnelRegister);
            break;
        case "4":
            PrintPersonnelList(personnelRegister);
            break;
        case "5":
            quit = true;
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}

static string ReadMenuChoice()
{
    Console.WriteLine();
    Console.WriteLine("Personnel Register Menu");
    Console.WriteLine("-----------------------");
    Console.WriteLine();
    Console.WriteLine("1. Add Personnel");
    Console.WriteLine("2. Remove Personnel");
    Console.WriteLine("3. Find Personnel");
    Console.WriteLine("4. Print Personnel List");
    Console.WriteLine("5. Quit");
    Console.WriteLine();
    Console.Write("Enter your choice: ");
    var choice = Console.ReadLine();

    return choice ?? string.Empty;
}

static void AddPersonnel(PersonnelRegister personnelRegister)
{
    Console.WriteLine();
    Console.WriteLine("Add Personnel");
    Console.WriteLine("-------------");
    Console.WriteLine();
    var personnel = ReadPersonnel();
    personnelRegister.AddPersonnel(personnel);
}

static void RemovePersonnel(PersonnelRegister personnelRegister)
{
    Console.WriteLine();
    Console.WriteLine("Remove Personnel");
    Console.WriteLine("----------------");
    Console.WriteLine();
    var id = ReadPersonnelId();
    Console.WriteLine();
    if (personnelRegister.RemovePersonnel(id))
    {
        Console.WriteLine($"Personnel with ID {id} removed successfully.");
    }
    else
    {
        Console.WriteLine($"Could not find Personnel with ID {id}.");
    }
}

static void FindPersonnel(PersonnelRegister personnelRegister)
{
    Console.WriteLine();
    Console.WriteLine("Find Personnel");
    Console.WriteLine("--------------");
    Console.WriteLine();
    var id = ReadPersonnelId();
    var personnel = personnelRegister.FindPersonnel(id);
    if (personnel.Id != Guid.Empty)
    {
        PrintPersonnel(personnelRegister, personnel);
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"Could not find Personnel with ID {id}.");
    }
}

static void PrintPersonnel(PersonnelRegister personnelRegister, Personnel personnel)
{
    Console.WriteLine();
    Console.WriteLine("Personnel");
    Console.WriteLine("---------");
    Console.WriteLine();
    PersonnelRegister.PrintPersonnel(personnel);
}
static void PrintPersonnelList(PersonnelRegister personnelRegister)
{
    Console.WriteLine();
    Console.WriteLine("Personnel List");
    Console.WriteLine("--------------");
    Console.WriteLine();
    personnelRegister.PrintPersonnelList();
}

static Personnel ReadPersonnel()
{
    var firstName = ReadFirstName();
    var middleName = ReadMiddleName();
    var lastName = ReadLastName();
    var salary = ReadSalary();

    var personnel = new Personnel(Guid.NewGuid(), firstName, middleName, lastName, salary);
    
    return personnel;
}

static Guid ReadPersonnelId()
{
    var idInput = string.Empty;
    var id = Guid.Empty;

    do
    {
        Console.Write("Enter Personnel ID (GUID format): ");
        idInput = Console.ReadLine();
    }
    while (string.IsNullOrWhiteSpace(idInput) || !Guid.TryParse(idInput, out id));

    return id;
}

static string ReadFirstName()
{
    var firstName = string.Empty;

    do
    {
        Console.Write("Enter First Name: ");
        firstName = Console.ReadLine();
    }
    while (string.IsNullOrWhiteSpace(firstName));

    return firstName;
}

static string ReadMiddleName()
{
    Console.Write("Enter Middle Name (optional): ");
    var middleName = Console.ReadLine();
    return middleName ?? string.Empty;
}

static string ReadLastName()
{
    var lastName = string.Empty;

    do
    {
        Console.Write("Enter Last Name: ");
        lastName = Console.ReadLine();
    }
    while (string.IsNullOrWhiteSpace(lastName));

    return lastName;
}

static decimal ReadSalary()
{
    var salaryInput = string.Empty;
    var salary = 0.0M;

    do
    {
        Console.Write("Enter Salary: ");
        salaryInput = Console.ReadLine();
    }
    while (string.IsNullOrWhiteSpace(salaryInput) || !decimal.TryParse(salaryInput, out salary));

    return salary;
}
