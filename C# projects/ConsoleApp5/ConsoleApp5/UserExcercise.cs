using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base()
        {

        }

        public UserAlreadyLoggedInException(string message) : base(message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.Write("Press any key to go back to main page....");
            string input = Console.ReadLine();
            if (input.Length != 0)
            {
                UserExcercise.UserDemo();
            }
        }
    }
    class User
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    class UserExcercise
    {
        static List<User> userList = new List<User>();
        static bool loggedIn = false;

        static void CallMainPage()
        {
            Console.Write("Press any key to go back to main page....");
            string input = Console.ReadLine();
            if (input.Length != 0)
            {
                UserDemo();
            }
        }
        static void RegisterUser()
        {
            Console.Clear();
            Console.WriteLine("Register Page");
            Console.WriteLine("=============");
            Console.Write("Enter a username: ");
            string usr = Console.ReadLine();
            Console.Write("Enter a password: ");
            string pwd = Console.ReadLine();
            userList.Add(new User() { username = usr, password = pwd });
            Console.WriteLine("Registered Successfully");
            CallMainPage();
        }
        public static void LogInUser()
        {
            if (loggedIn)
            {
                throw new UserAlreadyLoggedInException("User already logged in!");
            }
            bool userFound = false;
            Console.Clear();
            Console.WriteLine("Log In Page");
            Console.WriteLine("===========");
            Console.Write("Enter username: ");
            string usr = Console.ReadLine();
            Console.Write("Enter password: ");
            string pwd = Console.ReadLine();
            foreach (User user in userList)
            {
                if (user.username == usr && user.password == pwd)
                {
                    userFound = true;
                }
            }
            if (userFound)
            {
                loggedIn = true;
                Console.WriteLine("Logged In successfully");             
            }
            else
            {
                Console.WriteLine("User not found");
                
            }
            CallMainPage();
        }
        public static void ShowDashboard()
        {
            Console.Clear();
            if (loggedIn)
            {
                Console.WriteLine("Dashboard Page");
                Console.WriteLine("==============");
                Console.WriteLine("\nHello World!\n");
            }
            else
            {
                Console.WriteLine("Please Log In");
            }
            CallMainPage();
        }
        public static void LogOutUser()
        {
            if (loggedIn)
            {
                loggedIn = false;
                Console.WriteLine("Logged out successfully");
            }
            else
            {
                Console.WriteLine("No User currently logged in");
            }
        }
        public static void UserDemo()
        {
            int flag = 0;
            while (flag == 0)
            {
                Console.Clear();
                Console.WriteLine("-----Main Menu-----");
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1.Register");
                Console.WriteLine("2.Log In");
                Console.WriteLine("3.Dashboard");
                Console.WriteLine("4.Log Out");
                Console.WriteLine("5.Exit");
                Console.Write("Enter option: ");
                bool success = int.TryParse(Console.ReadLine(), out int opt);
                switch (opt)
                {
                    case 1: RegisterUser();
                        break;
                    case 2: LogInUser();
                        break;
                    case 3: ShowDashboard();
                        break;
                    case 4: LogOutUser();
                        Console.ReadLine();
                        break;
                    case 5: flag = 1;
                        break;
                    default: Console.WriteLine("Enter valid option");
                        Console.ReadLine();
                        break;
                }
                
            }
        }
    }
}
