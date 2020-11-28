using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace OOP_Project___Hospital_Management_System
{
    class Laboratory:Person

    {
        public string testfor { get; set; }
        public Laboratory() : base() { }

        public Laboratory(string iD,string name,string email,string gender,string tel,string address, string test):base(iD,name,email,gender,tel,address)
        {
            this.testfor = test;
        }
    }
}