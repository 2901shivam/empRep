// See https://aka.ms/new-console-template for more information
using ConAppTwo;

Console.WriteLine("Hello, World!");


List<Employee> employee = new List<Employee>()
{
    new Employee(){Id=1,Name="Vijay",Designation="Developer",Doj=new DateTime(day:12,month:11,year:2022) },
     new Employee(){Id=2,Name="Niraj",Designation="Tester",Doj=new DateTime(day:10,month:11,year:2023) },
      new Employee(){Id=3,Name="Ravi",Designation="Developer",Doj=new DateTime(day:12,month:11,year:2022) },
       new Employee(){Id=4,Name="Sam",Designation="Developer",Doj=new DateTime(day:12,month:11,year:2022) },
};
foreach(Employee emp in employee)
{
    Console.WriteLine("Id"+emp.Id);
    Console.WriteLine("Name" + emp.Name);
    Console.WriteLine("Designation" + emp.Designation);
    Console.WriteLine("Doj" + emp.Doj);
}
Console.ReadKey();