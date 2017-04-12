using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvergeMusicStoreDAL
{
    public class AccountDAL
    {
        public  void CreateUser(User user)
        {
            MyMusicStoreEntities dbContext = new MyMusicStoreEntities();
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
    }
}
