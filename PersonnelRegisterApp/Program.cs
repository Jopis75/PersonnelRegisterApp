using PersonnelRegisterClassLibrary;

var personnelRegister = new PersonnelRegister();

var quit = false;

while (!quit)
{
    PrintMenu();

    Console.WriteLine();
    Console.WriteLine("Enter your choice: ");
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            var personnel = ReadPersonnel();
            personnelRegister.AddPersonnel(personnel);
            break;
        case "2":
            // Remove Personnel logic.
            break;
        case "3":
            // Find Personnel logic.
            break;
        case "4":
            Console.WriteLine();
            personnelRegister.PrintPersonnelList();
            Console.WriteLine();
            break;
        case "5":
            quit = true;
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}

static void PrintMenu()
{
    Console.WriteLine("Personnel Register Menu:");
    Console.WriteLine();
    Console.WriteLine("1. Add Personnel");
    Console.WriteLine("2. Remove Personnel");
    Console.WriteLine("3. Find Personnel");
    Console.WriteLine("4. Print Personnel List");
    Console.WriteLine("5. Quit");
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


static string ReadFirstName()
{
    var firstName = string.Empty;

    do
    {
        Console.WriteLine("Enter First Name: ");
        firstName = Console.ReadLine();
    }
    while (string.IsNullOrWhiteSpace(firstName));

    return firstName;
}

static string ReadMiddleName()
{
    Console.WriteLine("Enter Middle Name (optional): ");
    var middleName = Console.ReadLine();
    return middleName ?? string.Empty;
}

static string ReadLastName()
{
    var lastName = string.Empty;

    do
    {
        Console.WriteLine("Enter Last Name: ");
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
        Console.WriteLine("Enter Salary: ");
        salaryInput = Console.ReadLine();
    }
    while (string.IsNullOrWhiteSpace(salaryInput) || !decimal.TryParse(salaryInput, out salary));

    return salary;
}
