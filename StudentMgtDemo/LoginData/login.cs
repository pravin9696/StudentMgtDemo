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

        // update operation

        //update username AND password
         public void updateLoginDetails()
        {
            string uname; //old
            string pass;  //old
            
            string new_uname;//new
            string new_pass; //new 
            Console.WriteLine("enter old username and password");
            uname = Console.ReadLine();
            pass = Console.ReadLine();

            Model.Login lg = dbo.Logins.FirstOrDefault(x => x.UserName == uname && x.Password == pass);
            if (lg!=null)
            {
                Console.WriteLine("enter new user name and password");
                new_uname = Console.ReadLine();
                new_pass = Console.ReadLine();

                lg.UserName = new_uname;
                lg.Password=new_pass;
                int n=0;
                try
                {
                     n = dbo.SaveChanges();
                }
                catch(Exception e)
                {
                    Console.WriteLine("New Username exist in DB");
                }
                    if (n>0)
                {
                    Console.WriteLine("username & password updated successfully...");
                }
                else
                {
                    Console.WriteLine("unable to update username and password!!!");
                }

            }
            else
            {
                Console.WriteLine("invalid old username or password!!");
                Console.WriteLine("username and password updation not allowed!!!");
            }

            string ss = "abc";
            ss.Contains('a');

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
                return true;
            }
            else
            {                
                return false;
            }
        }

    }
}
