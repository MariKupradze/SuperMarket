using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket2
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        


        public User(int Id, string Name, string Surname, int Age, string Email, string Passowrd, string Address, string PhoneNumber)
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            this.Email = Email;
            this.Password = Passowrd;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;

        }

        public User()
        {
        

        }
    }
}
