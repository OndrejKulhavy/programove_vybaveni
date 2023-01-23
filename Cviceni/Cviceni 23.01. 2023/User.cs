using System;
using System.Security.Cryptography;

namespace Cviceni_23._01._2023
{
    class User
    {
        #region Fields
        private string firstName;
        private string lastName;
        private string userName;
        private string password;
        private bool isLoggedIn = false;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string UserName
        {
            get => userName;
            set => userName = value;
        }

        public string Password
        {
            get => password;
            set
            {
                if (isPasswordInValidFormat(value))
                    password = hashPassword(value);
                else
                    throw new Exception("Password is not in valid format");
            }
        }
        #endregion

        public User(string firstName, string lastName, string userName)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
        }

        public void LogIn(string password)
        {
            if (isPasswordCorrect(password)){
                isLoggedIn = true;
                Console.WriteLine("Logged in");
                
            }
            else{
                Console.WriteLine("Wrong password");
                isLoggedIn = false;
            }

            string currentDirectory = System.IO.Directory.GetCurrentDirectory();
            System.IO.File.AppendAllText(currentDirectory + "\\logins.txt", userName + " " +isLoggedIn+ " " + DateTime.Now + Environment.NewLine);
        }

        #region Password management
        private bool isPasswordInValidFormat(string password)
        {
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasNumber = false;
            bool hasSpecialCharacter = true;//TODO: implement
            bool hasMinimumLength = false;

            if (password.Length >= 8)
                return true;

            foreach (var character in password)
            {
                if (character >= 'A' && character <= 'Z')
                    hasUpperCase = true;
                else if (character >= 'a' && character <= 'z')
                    hasLowerCase = true;
                else if (character >= '0' && character <= '9')
                    hasNumber = true;
            }
            return hasUpperCase && hasLowerCase && hasNumber && hasSpecialCharacter && hasMinimumLength;
        }

        //has password using 
        private string hashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            return Convert.ToBase64String(hashBytes);
        }

        public bool isPasswordCorrect(string password)
        {
            byte[] hashBytes = Convert.FromBase64String(this.password);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    return false;
            return true;
        }
        #endregion

        public override string ToString()
        {
            return $"First name: {firstName}, Last name: {lastName}, Username: {userName}";
        }
    }
}
