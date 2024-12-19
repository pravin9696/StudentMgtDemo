using StudentMgtDemo.admin_Task;
using StudentMgtDemo.Login;
using System;

namespace StudentMgtDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isLogedIn = false;
            int ch;
            do
            {
                if (isLogedIn == false)
                {
                    Console.WriteLine("1:login");
                    Console.WriteLine("2:SignUp");
                }
                else
                {
                    Console.WriteLine("5:Sign out");
                }
                Console.WriteLine("6:Exit");
                Console.WriteLine("Enter choice");
                ch = int.Parse(Console.ReadLine());
                loginClass lg = new loginClass();
                switch (ch)
                {
                    case 1:
                        if (isLogedIn == true)
                        {
                            Console.WriteLine("already logged in. please sign out..");
                        }
                        else
                        {

                            bool result = lg.IsLogin();
                            if (result)
                            {
                                isLogedIn = true;
                                Console.WriteLine("welcome...");
                                AdminClass acObj = new AdminClass();
                                acObj.AdminTask();
                            }
                        }
                        break;
                    case 2:

                        bool r = lg.SignUp();
                        break;
                    case 5:
                        if (isLogedIn == true)
                        {
                            isLogedIn = false;
                        }
                        else
                        {
                            Console.WriteLine("not logged in yet!!!");
                        }
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            } while (true);
            Console.ReadKey();
        }
    }
}
