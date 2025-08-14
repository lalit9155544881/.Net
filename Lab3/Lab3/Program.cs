using System;
class Empoyee
{
    string name;
    int age;
    string salary;
    public void GetData()
    {
        Console.WriteLine("enter name");
        name = Console.ReadLine();
        Console.WriteLine("enter age");
        age = Console.Read();
        Console.WriteLine("enter salary");
        salary = Console.ReadLine();

    }
    public void DisplayData()
    {
        Console.WriteLine("Name:" + name);
        Console.WriteLine("age" + name);
        Console.WriteLine("salary" + salary);
    }
    static void Main(String[] args)
    {
        Empoyee emp = new Empoyee();
        emp.GetData();
        emp.DisplayData();
    }
}
    