using System;

class Supply
{
    //public string Bill_of_Supply_Details;
    public int Bill_of_Supply_Number;
    public String Bill_of_Supply_Date;
    public double Order_Number;
    public String Customer_Name;
    public String Customer_address;
    public String Customer_Contact_Number;
    public String Product_Name;
    public String Product_Quantity;
    public string Product_Price;
    public string  Total_Price;
     

    public Supply( int a, String b, double s , String n, String m, String o, String p, String q, String r, String t )
    {
        //Bill_of_Supply_Details= n;
        Bill_of_Supply_Number = a;
        Bill_of_Supply_Date = b;
        Order_Number = s;
        Customer_Name = n;   
        Customer_address = m;
        Customer_Contact_Number = o ;
        Product_Name = p;
        Product_Quantity = q;
        Product_Price = r;
        Total_Price = t;
    }

    public void display()
    {
        //Console.WriteLine("Supply details");
        Console.WriteLine("Bill_of_Supply_Number " +Bill_of_Supply_Number);
        Console.WriteLine("Bill_of_Supply_Date " +Bill_of_Supply_Date);
        Console.WriteLine("Order_Number "   +Order_Number);
        Console.WriteLine();
        Console.WriteLine("Customer_Name " +Customer_Name);
        Console.WriteLine("Customer_address " +Customer_address);
        Console.WriteLine("Customer_Contact_Number " +Customer_Contact_Number);
        Console.WriteLine();
        Console.WriteLine("Product_Name " +Product_Name);
        Console.WriteLine("Product_Quantity " +Product_Quantity);
        Console.WriteLine("Product_Price " +Product_Price);
        Console.WriteLine("Total_Price " +Total_Price);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Supply e1 = new Supply(215,"DD/MM/YY", 158425252053, "Shalini", "Patna Bihar", "9876543210", "Laptop", "1", "50000", "50000");
        e1.display();
    }
    
}