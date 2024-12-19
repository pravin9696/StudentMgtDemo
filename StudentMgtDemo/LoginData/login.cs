using StudentMgtDemo.Model;
using System;
using System.Linq;

namespace StudentMgtDemo.Login
{
    internal class loginClass
    {
        StudentMGTEntities dbo = new StudentMGTEntities();

        // signup or Create
        public bool SignUp()
        {
            string un;//un username
            string Pass;//password;
            Console.WriteLine("Enter User Name and password for Signup");
            un = Console.ReadLine();
            Pass = Console.ReadLine();

            Model.Login lg = new Model.Login();
            lg.UserName = un;
            lg.Password = Pass;


            dbo.Logins.Add(lg);
            int n = dbo.SaveChanges();
            if (n > 0)
            {
                Console.WriteLine("Sign up successfully..");
                return true;
            }
            else
            {
                Console.WriteLine("unable of sign up!!!!");
                return false;
            }
        }



        //Read operation
        public bool IsLogin()
        {
            string uname;
            string pass;
            Console.WriteLine("enter User Name and Password");
            uname = Console.ReadLine();
            pass = Console.ReadLine();

            var lg = dbo.Logins.FirstOrDefault(x => x.UserName == uname && x.Password == pass);
            if (lg != null)//lg contain object of Login class
            {
                Console.WriteLine("login successful...");
                return true;
            }
            else
            {
                Console.WriteLine("invalid username or password");
                return false;
            }
        }

    }
}
