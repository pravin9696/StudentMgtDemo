using StudentMgtDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtDemo.Login
{
    internal class loginClass
    {
        StudentMGTEntities dbo = new StudentMGTEntities();
        //Read operation
        public bool IsLogin()
        {
            string uname;
            string pass;
            Console.WriteLine("enter User Name and Password");
            uname = Console.ReadLine();
            pass= Console.ReadLine();

            var lg = dbo.Logins.FirstOrDefault(x => x.UserName == uname && x.Password == pass);
            if (lg!=null)
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
        public bool SignUp()
        {
            return true;    
        }
    }
}
