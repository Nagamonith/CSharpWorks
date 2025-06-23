using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {


        public void Addition(List<double> numbers)
        {
            // Normal for loop 
            //try
            //{
            //    double result = numbers[0];

            //    for (int i = 1; i < numbers.Count; i++)
            //    {
            //        result += numbers[i];

            //    }
            //    Console.WriteLine("the addition is " + result);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("no numbers to add ");
            //}

            // foreach loop
            try
            {
                double result = numbers[0];
                foreach (double num in numbers)
                {
                    result += num;
                }
                Console.WriteLine($"the addition is {result}");

            }
            catch
            {
                Console.WriteLine(" No numbers to add");
            }

        }

        public void Subtraction(List<double> numbers)
        {
            // Normal Loop
            //try
            //{
            //    double result = numbers[0];

            //    for (int i = 1; i < numbers.Count; i++)
            //    {
            //        result -= numbers[i];

            //    }
            //    Console.WriteLine("the Subtraction is " + result);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("NO numbers to subtract ");
            //}
            try
            {
                double result = numbers[0];
                foreach (double num in numbers)
                {
                    result -= num;
                }
            }
            catch
            {
                Console.WriteLine("NO numbers to subtract ");

            }

        }
        public void Multiplication(List<double> numbers)
        {

            //try
            //{
            //    double result = numbers[0];

            //    for (int i = 1; i < numbers.Count; i++)
            //    {
            //        result *= numbers[i];

            //    }
            //    Console.WriteLine("the multiplication is " + result);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("No Numbers to multiply");
            //}

            try
            {
                double result = numbers[0];
                foreach (double num in numbers)
                {
                    result *= num;
                }
            }
            catch
            {
                Console.WriteLine("No Numbers to multiply");
            }
            
        }

        public void Division(double i, double j)
        {
            
            try
            {

                Console.WriteLine("the division is " + ((double)i / j));
            }
            catch
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }

        public void Percantage(double i, double j)
        {
            
            try
            {
                Console.WriteLine("the percantage is " + ((double)i / j * 100) + "%");
            }
            catch
            {
                Console.WriteLine("Cannot calculate percentage with denominator zero");
            }
        }

        public void GetTowNumber(out double num1 , out double num2)
            {
                Console.WriteLine("Enter number one-");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter number two-");
                num2 = double.Parse(Console.ReadLine());
                
                
            }
        
            
        public static void Calculate()
        {
            bool cursor = true;
            while (cursor)
            {
                Calculator calculate = new Calculator();
                Console.WriteLine(" enter 1 for addition->");
                Console.WriteLine(" enter 2 for subtraction->");
                Console.WriteLine(" enter 3 for multiplication->");
                Console.WriteLine(" enter 4 for division->");
                Console.WriteLine(" enter 5 for percentage->");
                Console.WriteLine(" enter 6 for Exit->");
                Console.WriteLine(" enter your choice->");

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        {
                            List<double> numbers = new List<double>();
                            try
                            {
                                while (true)
                                {
                                    Console.WriteLine("Enter Number for continue adding number or done for stop adding number:");
                                    string response = Console.ReadLine();
                                    if (response.ToLower() == "done")
                                    {
                                        calculate.Addition(numbers);
                                        break;
                                    }
                                    else
                                    {
                                        double pushResponse = double.Parse(response);
                                        numbers.Add(pushResponse);
                                    }
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Invalid input");
                            }
                            break;
                        }

                    case 2:
                        {
                            List<double> numbers = new List<double>();
                            try
                            {
                                while (true)
                                {
                                    Console.WriteLine("Enter Number for continue subtracting number or done for stop subtracting number:");
                                    string response = Console.ReadLine();
                                    if (response.ToLower() == "done")
                                    {
                                        calculate.Subtraction(numbers);
                                        break;
                                    }
                                    else
                                    {
                                        double pushResponse = double.Parse(response);
                                        numbers.Add(pushResponse);
                                    }
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Invalid input");
                            }
                            break;
                        }

                    case 3:
                        {
                            List<double> numbers = new List<double>();
                            try
                            {
                                while (true)
                                {
                                    Console.WriteLine("Enter Number for continue multiplying number or done for stop multiplying number:");
                                    string response = Console.ReadLine();
                                    if (response.ToLower() == "done")
                                    {
                                        calculate.Multiplication(numbers);
                                        break;
                                    }
                                    else
                                    {
                                        double pushResponse = double.Parse(response);
                                        numbers.Add(pushResponse);
                                    }
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Invalid input");
                            }
                            break;
                        }

                    case 4:
                        {
                            try
                            {
                                double num1, num2;
                                calculate.GetTowNumber(out num1, out num2);
                                calculate.Division(num1, num2);
                            }
                            catch
                            {
                                Console.WriteLine("Invalid input for division.");
                            }
                            break;
                        }

                    case 5:
                        {
                            try
                            {
                                double num1, num2;
                                calculate.GetTowNumber(out num1, out num2);
                                calculate.Percantage(num1, num2);

                            }
                            catch
                            {
                                Console.WriteLine("Invalid input for percentage.");
                            }
                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine("Exiting..");
                            cursor = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                        }
                }
            }
        }
    }
}