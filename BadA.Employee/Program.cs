using BadA.Employee;

Employees employee0 = new Employees("Tolu", 1000000, "King of the World");
Employees employee1 = new Employees("Travis", .02, "Chairman of the Peanut Gallery");
Employees employee2 = new Employees("Robot", 3.50, "Coffee Snob");

List<Employees> employees = new List<Employees>()
{
    {employee0},
    {employee1},
    {employee2},
    {new Employees("Justin", 1, "Chief Cat Wrangler") },
    {new Employees("Josh", 10, "Neo") }
};

employees.ForEach(e => e.EmployeeInfo());