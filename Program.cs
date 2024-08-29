using System;
using System.Net;
using System.Numerics;

namespace MyApp
{
    public class Q1A1
    {
        public Q1A1()
        {
            decimal[] prices = new decimal[5]; // Assuming you want to store prices as decimals

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter item " + (i + 1) + " cost: ");
                string input = Console.ReadLine(); // Read the entire line of input
                if (decimal.TryParse(input, out decimal cost))
                {
                    prices[i] = cost;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                    i--; // Re-prompt for the same index
                }
            }

            decimal total = 0;

            foreach (decimal price in prices)
            {
                total += price;
            }

            total = total > 3000 ? total / 100 * 90 : total;
            Console.WriteLine("Total cost: " + total);
        }
    }
    public class Q2A2
    {
        public Q2A2()
        {
            Console.Write("Enter temp in celcius: ");
            int c = Console.Read();
            int f = (c * (9 / 5)) + 32;
            if (c <= 0)
            {
                Console.WriteLine("Freezing temperature");
            }
            Console.WriteLine(f + " f");
        }
    }
    public class Q3A3
    {
        public class ATM
        {
            int balance;
            public ATM(int balance)
            {
                this.balance = balance;
            }

            public int CheckBalance()
            {
                return balance;
            }

            public void Deposite(int amount)
            {
                balance += amount;
                Console.WriteLine("Successfully Deposite");
            }

            public void WithDraw(int amount)
            {
                if (amount > balance)
                {
                    Console.WriteLine("UnSufficient balance");
                    return;
                }
                balance -= amount;
                Console.WriteLine("succesfully wwithdraw");
            }
        }
        public Q3A3()
        {
            ATM obj = new ATM(5000);
            obj.Deposite(2000);
            obj.WithDraw(10000);
            obj.Deposite(3000);
            obj.WithDraw(10000);
        }
    }
    public class Q4A4
    {
        public class Student
        {
            double hindi, english, maths, physics, chemistry;
            public Student(decimal english, decimal hindi, decimal maths, decimal physics, decimal chemistry)
            {
                this.hindi = (double)hindi;
                this.english = (double)english;
                this.maths = (double)maths;
                this.chemistry = (double)chemistry;
                this.physics = (double)physics;
            }

            public double Average()
            {
                double avg = hindi + english + maths + physics + chemistry;
                return avg / 5;
            }
        }
        public Q4A4()
        {
            string input;
            decimal english, hindi, maths, physics, chemistry;
            Console.Write("Enter Marks of English: ");
            input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal marks1))
                english = marks1;
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                return;
            }
            Console.Write("Enter Marks of Hindi: ");
            input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal marks2))
                hindi = marks2;
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                return;
            }
            Console.Write("Enter Marks of Maths: ");
            input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal marks3))
                maths = marks2;
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                return;
            }
            Console.Write("Enter Marks of physics: ");
            input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal marks4))
                physics = marks2;
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                return;
            }
            Console.Write("Enter Marks of chemistry: ");
            input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal marks5))
                chemistry = marks2;
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                return;
            };
            Student s1 = new Student(english, hindi, maths, physics, chemistry);
            Console.WriteLine("Average: " + s1.Average());
        }
    }
    public class Q5A5
    {
        public Q5A5()
        {
            Console.Write("Enter Password: ");
            string? password = Console.ReadLine();
            if (password?.Length < 8)
            {
                Console.WriteLine("Password length is less than 8");
                return;
            }

            Boolean hasUpperCase = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true;
                }
            }
            if (!hasUpperCase)
            {
                Console.WriteLine("Password does not contain Upper case letter");
                return;
            }

            Boolean hasLowerCase = false;
            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    hasLowerCase = true;
                }
            }
            if (!hasLowerCase)
            {
                Console.WriteLine("Password does not contain Lower case letter");
                return;
            }

            Boolean hasDigit = false;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
            }
            if (!hasDigit)
            {
                Console.WriteLine("Password does not contain digit");
                return;
            }

            Console.WriteLine("Password is Correct");
        }
    }
    public class Q6A6
    {
        public Q6A6()
        {
            Console.Write("Enter distance in km: ");
            int km = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter time (24hr format): ");
            int time = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter additional night charge: ");
            int nightCharge = Convert.ToInt32(Console.ReadLine());
            if (km <= 2)
            {
                Console.WriteLine("Total fair: " + 20);
                return;
            }
            int fair = 20;
            fair += km * 10;

            if (time > 22 && time < 5)
            {
                fair += nightCharge;
            }

            Console.WriteLine("Total fair: " + fair);
        }
    }
    public class Q7A7
    {
        public class Attendance
        {
            int attendance = 0;
            int totalDay = 5;

            public void Attend()
            {
                attendance++;
            }

            public int PresentDays()
            {
                return attendance;
            }

            public Boolean HasPrefectAttendance()
            {
                return attendance >= totalDay / 2 ? true : false;
            }
        }
        public Q7A7()
        {
            Attendance a = new Attendance();
            a.Attend();
            a.Attend();
            a.Attend();
            a.Attend();
            Console.WriteLine(a.PresentDays());
            Console.WriteLine(a.HasPrefectAttendance());
        }
    }
    public class Q8A8
    {
        public Q8A8()
        {
            int[] months = new int[12];

            for (int i = 0; i < 12; i++)
            {
                Console.Write("Enter " + (i + 1) + " month expense: ");
                months[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = 1, min = 1;
            for (int i = 0; i < 12; i++)
            {
                if (months[max] < months[i])
                {
                    max = i;
                }
                else if (months[min] > months[i])
                {
                    min = i;
                }
            }

            Console.WriteLine("Max Month: " + max + 1);
            Console.WriteLine("Min Month: " + min + 1);
        }
    }
    public class Q9A9
    {
        public class ShopingCart
        {
            Dictionary<string, double> cart = new Dictionary<string, double>();
            double total = 0;

            public void AddItem(string name, double price)
            {
                cart.Add(name, price);
                total += price;
            }

            public void RemoveItem(string name)
            {
                total -= cart[name];
                cart.Remove(name);
            }

            public void GetTotal()
            {
                Console.WriteLine("Total: " + total);
            }
        }
        public Q9A9()
        {
            ShopingCart cart = new ShopingCart();
            cart.AddItem("Laptop", 100000);
            cart.AddItem("Mobile", 45000);
            cart.RemoveItem("Mobile");
            cart.GetTotal();
        }
    }
    public class Q10A10
    {
        public Q10A10()
        {
            Console.Write("Enter wages per week: ");
            int wagePerWeek = Convert.ToInt32(Console.ReadLine());
            int[] hoursPerWeek = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter " + (i + 1) + " working hours: ");
                hoursPerWeek[i] = Convert.ToInt32(Console.ReadLine());
            }

            int monthlySalary = 0;
            foreach (int hours in hoursPerWeek)
            {
                monthlySalary += hours * wagePerWeek;
            }
            Console.WriteLine("Monthly Salary: " + monthlySalary);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // new Q1A1();
            // new Q2A2();
            // new Q3A3();
            // new Q4A4();
            // new Q5A5();
            // new Q6A6();
            // new Q7A7();
            // new Q8A8();
            // new Q9A9();
            new Q10A10();
        }
    }
}