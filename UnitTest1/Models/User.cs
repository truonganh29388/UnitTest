using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest1.Models
{
    public interface IUser
    {
         string FirstName { get; set; }
         string LastName { get; set; }
         string Email { get; set; }
         DateTime DOB { get; set; }
         string Phone { get; set; }
         string POB { get; set; }

         //string FullName { get; }

        string GetFullName();
    }
    public class User:IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string POB { get; set; }

        //public string FullName { get { return FirstName + LastName; } }    
        
        public string GetFullName()
        {
            return FirstName + LastName;
        }
    }
}
