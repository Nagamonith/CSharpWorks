using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Customer
{
    internal class Bank_Customer
    {
        class Customer
        {
            int _Cid;
            string _Cname;
            bool _Status;
            double _Balance;

            public Customer(int cid, string cname, bool status, double balance)
            {
                _Cid = cid;
                _Cname = cname;
                _Status = status;
                _Balance = balance;
            }
            public int Cid
            {
                get { return _Cid; }
            }
            public string Cname
            {
                get { return _Cname; }
                set { _Cname = value; }
            }
            public bool Status
            {
                get { return _Status; }
                set { _Status = value; }
            }
            public double Balance
            {
                get { return _Balance; }
                set
                {
                    if (value < _Balance)
                    {
                        _Balance = value;
                    }
                }
            }
            public void SetStatus(bool status)
            {
                _Status = status;
            }
        }
        

        static void Main()
        {
            Customer c1 = new Customer(101, "monith", false, 50000);
            bool entry = true;
            while (entry)
            {
                Console.WriteLine("Enter 1 to see the details of user->1");
                Console.WriteLine("Enter 2 to see the details of balance->2");
                Console.WriteLine("Enter 3 to see the details of status->3");
                Console.WriteLine("Enter 4 to withdraw the balance->4");
                Console.WriteLine("Enter 5 to exit->5");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine($"Customer ID: {c1.Cid}, Name: {c1.Cname}");
                        break;
                    case 2:
                        if (c1.Status == true)
                        {
                            Console.WriteLine($"Customer ID : {c1.Cid} , Balance {c1.Balance}");
                        }
                        else
                        {
                            Console.WriteLine("The user is not active please YES to activate");
                            string status = Console.ReadLine();
                            if (status == "yes" || status == "YES")
                            {
                                Console.WriteLine($"Customer ID : {c1.Cid} , Balance {c1.Balance}");


                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Customer Status: {(c1.Status ? "Active" : "Inactive")}");
                        break;
                    case 4:
                        if (c1.Status == true)
                        {
                            Console.WriteLine("Enter the amount to withdraw:");
                            double amount = double.Parse(Console.ReadLine());
                            if (amount <= c1.Balance)
                            {
                                c1.Balance -= amount;
                                Console.WriteLine($"Withdrawal successful. Remaining balance: {c1.Balance}");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The user is not active please YES to activate");
                            string status = Console.ReadLine();
                          
                            Console.WriteLine("Enter the amount to withdraw:");
                            double amount = double.Parse(Console.ReadLine());
                            if (amount <= c1.Balance)
                            {
                                c1.Balance -= amount;
                                Console.WriteLine($"Withdrawal successful. Remaining balance: {c1.Balance}");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance.");
                            }

                        }
                            break;
                    case 5:
                        entry = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
    }
}
