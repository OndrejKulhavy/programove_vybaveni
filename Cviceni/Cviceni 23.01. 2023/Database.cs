using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Cviceni_23._01._2023
{
    class Database
    {
        private List<User> users;

        //constructor
        public Database()
        {
            users = new List<User>();
        }

        public void RegisterNewUser()
        {
            Console.WriteLine("Zadejte křestní jméno uzivatele: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení uzivatele: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Zadejte uzivatelske uzivatele: ");
            string name = Console.ReadLine();
            Console.WriteLine("Zadejte heslo uzivatele: ");
            string password = Console.ReadLine();

            //check if user with this username already exists using liqn
            if (users.Any(user => user.UserName == name))
            {
                Console.WriteLine("Uzivatel s timto uzivatelskym jmenem uz existuje");
                return;
            }

            User user = new User(firstName, lastName, name);
            try
            {
                user.Password = password;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            users.Add(user);
        }
       
        public User LogIn()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("Neexistuje zadny uzivatel");
                return null;
            }
            Console.WriteLine("Zadejte uzivatelske jmeno: ");
            string name = Console.ReadLine();
            Console.WriteLine("Zadejte heslo: ");
            string password = Console.ReadLine();

            //find user with this username
            User user = users.FirstOrDefault(u => u.UserName == name);

            if (user == null)
            {
                Console.WriteLine("Uzivatel s timto uzivatelskym jmenem neexistuje");
                return null;
            }
            user.LogIn(password);
            return user;
           }

        public void SaveToFile()
        {
            string json;
            //serialize users to json
            json = JsonSerializer.Serialize(users);
            //save json to file

            string currentDirectory = System.IO.Directory.GetCurrentDirectory();
            System.IO.File.WriteAllText(currentDirectory + "\\users.json", json);
        }

        public void LoadFromFile()
        {
            string currentDirectory = System.IO.Directory.GetCurrentDirectory();
            string json = System.IO.File.ReadAllText(currentDirectory + "\\users.json");
            users = JsonSerializer.Deserialize<List<User>>(json);
        }

        public void PrintAllUsers()
        {
            foreach (User user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}
