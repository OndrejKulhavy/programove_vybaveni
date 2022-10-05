using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography;


namespace Cviceni_03._10._2022
{
    class Uzivatel : IComparable<Uzivatel>
    {
        private string nickname;
        private string password;
        public string Nickname
        {
            get { return nickname; }
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("Nickname musí mít alespoň 3 znaky");
                }
                nickname = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 5)
                {
                    throw new Exception("Password musí mít alespoň 5 znaků");
                }
                using (var sha = new SHA256Managed())
                {
                    var textData = System.Text.Encoding.UTF8.GetBytes(value);
                    var hash = sha.ComputeHash(textData);
                    password = BitConverter.ToString(hash).Replace("-", string.Empty);
                }
            }
        }
        public Uzivatel(string nickname, string password)
        {
            Nickname = nickname;
            Password = password;
        }
        
        public int CompareTo(Uzivatel other)
        {
            return Nickname.CompareTo(other.Nickname);
        }

        public override string ToString()
        {
            return "Uživatel: " + Nickname + " a heslem: " + Password;
        }
    }
}
