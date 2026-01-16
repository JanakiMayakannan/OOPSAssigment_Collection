using System;
using HRLib;

namespace HRAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region GIT
            Console.WriteLine("Changes done from git repository");
            #endregion
            try
            {
                Console.WriteLine("---- Confirm Employee (Valid) ----");
                ConfirmEmployee ce1 = new ConfirmEmployee("Ravi", "Pune", 30000, "Manager");
                Console.WriteLine(ce1);

                Console.WriteLine("\n---- Trainee ----");
                Trainee t1 = new Trainee("Amit", "Mumbai", 20, 500);
                Console.WriteLine(t1);

                Console.WriteLine("\n---- Confirm Employee (Invalid Basic) ----");
                ConfirmEmployee ce2 = new ConfirmEmployee("Rahul", "Delhi", 3000, "Clerk");
                Console.WriteLine(ce2);
            }
            catch (InvalidBasicException ex)
            {
                Console.WriteLine("Custom Exception Caught:");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception:");
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}

