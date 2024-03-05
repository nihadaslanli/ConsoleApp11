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


           
            set {
                if (value < 0)
                {
                    Console.WriteLine("Yasda - ola bilmez");

                }


                    _age = value; }
        }

        public string _Pasword
        {
            get { return _pasword; }
            set { _pasword = value; }
        }
    }
}
