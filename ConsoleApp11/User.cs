using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class User
    {
        private string _Name;
       private int _age;
        private string _pasword;


         public string Username
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int age
        {
            get { return _age; }  
            set { _age = value; }
        }

        public string _Pasword
        {
            get { return _pasword; }
            set { _pasword = value; }
        }

        //public User(string name, int age, string pasword)
        //{
        //    Console.WriteLine("ad daxil edin:");
        //    Name = Convert.ToString(Console.ReadLine());
        //    Console.WriteLine("yasinizi qeyd edin:");
        //    this.age = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("pasword daxil edin:");
        //    this.pasword = Convert.ToString(Console.ReadLine());
        //}
        //public void info()
        //{
        //    Console.WriteLine($"Name:{this.Name}age:{this.age},pasword:{this.pasword}");
        //}

    }


    
}
