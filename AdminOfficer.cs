namespace TestProject;

 class AdminOfficer:Employee
{
    

    public AdminOfficer(string argEmpNo, string argFirstName, int argAge, int argCategory, int argBasicSalary) : base(argEmpNo, argFirstName, argAge, argCategory, argBasicSalary)
    {
    }

    public void PrintDuty()
    {
        Console.WriteLine("Admin officer do administration");
    }
}
