using ConvergeMusicStoreDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateUser();
        }

        public static void CreateUser()
        {
            

            User user = new User();

            user.UserName = "Asim";
            user.Password = "Asim";
            user.Email = "Asim@gmail.com";
            user.CreatedDate = System.DateTime.UtcNow;

            AccountDAL dal = new AccountDAL();
            dal.CreateUser(user);
        }
    }
}
