﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************WITHOUT USING LINQ************************************************");

            UserRepository obj = new UserRepository();
            List<User> user = new List<User>();
            Console.WriteLine();
            Console.WriteLine("List of Users without using LINQ");
            user = obj.Users();
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (User users in user)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t" + users.location + "\t" + users.address + "\t  " + users.isActive);
            }
            Console.WriteLine();
            Found:
            Console.WriteLine("Enter the id for User you want to retrieve");
            int idUser = Convert.ToInt32(Console.ReadLine());
            User getUser = new User();
            getUser = obj.GetUser(idUser);
            if (getUser.id == 0)
            {
                Console.WriteLine("Entered Id is Invalid");
                goto Found;
            }
            else
            {
                Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
                Console.WriteLine(getUser.id + "\t" + getUser.name + "\t" + getUser.email + "\t" + getUser.location + "\t" + getUser.address + "\t  " + getUser.isActive);
            }
           
            Console.WriteLine();


            Console.WriteLine("Enter the id for User you want to Delete");
            int idUser2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("List of Users after Deleting User with ID =" +idUser2+" without using LINQ");

            List < User > listafterDeletion= new List<User>();
             listafterDeletion= obj.DeleteUser(idUser2);
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (User users in listafterDeletion)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t" + users.location + "\t" + users.address + "\t  " + users.isActive);
            }


            List<User> activeUser = new List<User>();

            activeUser = obj.ActiveUsers();
            Console.WriteLine();


            Console.WriteLine("List of Active Users without using LINQ");

            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (User users in activeUser)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t" + users.location + "\t" + users.address + "\t  " + users.isActive);
            }

            User obj2 = new User();
            obj2.id = 100;
            obj2.name = "Vivek";
            obj2.email = "vivek@gmail.com\t";
            obj2.location = "Motihari";
            obj2.address = "Bihar\t";
            obj2.isActive = true;
            Console.WriteLine();

            Console.WriteLine("After addition of new user in List");
            obj.AddUser(obj2);
            user = obj.Users();
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (User users in user)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t" + users.location + "\t" + users.address + "\t  " + users.isActive);
            }
            Console.WriteLine();
            Console.WriteLine("*****************************************************USING LINQ********************************************************");
            Console.WriteLine();
            Console.WriteLine("Enter the id for User you want to retrieve");
            int idUser1 = Convert.ToInt32(Console.ReadLine());
            var getIdUser = user.Where(users => users.id == idUser1);
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (User users in getIdUser)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t" + users.location + "\t" + users.address + "\t  " + users.isActive);
            }

            Console.WriteLine("Enter the id for User you want to Delete");

            int delUser = Convert.ToInt32(Console.ReadLine());

            user.RemoveAll(x => x.id == delUser);

            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (User users in user)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t" + users.location + "\t" + users.address + "\t  " + users.isActive);
            }

            var ActiveUsersLinq = user.Where(users => users.isActive == true);

            Console.WriteLine();
            Console.WriteLine("List of Active Users using LINQ");

            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");

            foreach (User users in ActiveUsersLinq)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t" + users.location + "\t" + users.address + "\t  " + users.isActive);
            }
            User newObject = new User();

            Console.WriteLine("Enter Users Details");

            Console.WriteLine("Enter User Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter User Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter User Email");
            string email = Console.ReadLine();

            Console.WriteLine("Enter User Location");
            string location = Console.ReadLine();

            Console.WriteLine("Enter User Address");
            string  address= Console.ReadLine();

            Console.WriteLine("Enter User Activity Status");
            bool activity = Convert.ToBoolean(Console.ReadLine());

            user.Add(new User() { id = id, name = name, email = email, location = location, address = address, isActive = activity });


            Console.WriteLine();

            Console.WriteLine("After addition of new user in List");
            obj.AddUser(obj2);
            user = obj.Users();
            Console.WriteLine("Id \t Name \t Email \t \t \tLocation \tAddress\t\tActiveStatus");
            foreach (User users in user)
            {
                Console.WriteLine(users.id + "\t" + users.name + "\t" + users.email + "\t\t" + users.location + "\t" + users.address + "\t  " + users.isActive);
            }
            Console.WriteLine();


        }

    }
}
