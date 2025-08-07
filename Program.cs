using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        private string username;
        private string password;
        private string? email;
        public void set()
        {
            Console.WriteLine("Enter the username");
            this.username = Console.ReadLine();
            Console.WriteLine("Enter the password");
            this.password = Console.ReadLine();
            while (password.Length < 6)
            {
                Console.WriteLine("Password must have 6 character");
                Console.WriteLine("Please enter the password");
                this.password = Console.ReadLine();
            }

            Console.WriteLine("Enter the email");
            this.email = Console.ReadLine();
            while (!this.email.Contains("@"))
            {
                {
                    Console.WriteLine("Email must contain @");
                    Console.WriteLine("Enter the email");
                    this.email = Console.ReadLine();
                }
            }
        }
        public void get()
        {
            Console.WriteLine("Username is :" + this.username);
            Console.WriteLine("Password is :" + this.password);
            Console.WriteLine("Email is :" + this.email);

        }
        static void Main(string[] args)
        {
            Program a = new Program();
            a.set();
            Program b = new Program();
            b.set();
            a.get();
            b.get();
        }
    }
}