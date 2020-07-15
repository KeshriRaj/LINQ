using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class UserRepository:IUserRepository
    {
        public List<User> users = new List<User>();
        public UserRepository()
        {
            Console.WriteLine("Enter number of Dummy Users data need to be Appended in List");
            int numberOfUser = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=numberOfUser;i++)
            {
                bool active = (i % 2 == 0) ? true : false;
                users.Add(new User() { id = i, name = "Kunal" + i, email = "kunal" + i + "@gmail.com", location = "Vellore" + i, address = "TamilNadu" + i, isActive = active });
            }
            
        }
        public List<User> Users()
        {
            return users;
        }
        

        public List<User> DeleteUser(int id)
        {
            foreach (User person in users)
            {
                if (person.id == id)
                {
                    users.Remove(person);
                    break;
                }

            }
            return users;
        }

        public List<User> ActiveUser = new List<User>();
        public List<User> ActiveUsers()
        {
            foreach (User person in users)
            {
                if (person.isActive)
                {
                    ActiveUser.Add(person);
                }

            }
            return ActiveUser;
        }
        User getuser = new User();
        public User GetUser(int id)
        {
            foreach(User person in users)
            {
                if(person.id==id)
                {
                   getuser= person;
                }
            }
            return getuser;
        }

        public List<User> AddUser(User user)
        {
            users.Add(user);
            return users;
        }



    }
}
