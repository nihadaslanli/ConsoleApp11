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
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public int age
        {
            get
            {
                return _age;
            }



            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Yasda - ola bilmez");

                }


                _age = value;
            }
        }

        public string Pasword
        {
            get
            {
                return Pasword;
            }
            set
            {
                foreach (var item in _pasword)
                {
                    if (value == null || value.Length < 8)
                    {
                        Console.WriteLine("Sifre bosh ola bilmez");
                        return;
                    }

                    if (value.Length < 8)
                    {
                        Console.WriteLine("Sifre en 8 Karakter uzunluquda olamlidir");
                        return;
                    }

                    bool hasUppercase = false;
                    bool hasDigit = false;
                    foreach (char c in value)
                    {
                        if (char.IsUpper(c))
                        {
                            hasUppercase = true;
                        }
                        else if (char.IsDigit(c))
                        {
                            hasDigit = true;
                        }
                    }

                    if (!hasUppercase)
                    {
                        Console.WriteLine("Sifre en az bir boyuk reqem olmalidir");
                        return;
                    }

                    if (!hasDigit)
                    {
                        Console.WriteLine("Sifre en az bir reqem olamlidir");
                        return;
                    }

                    Pasword = value;
                }
               

               
            }
        }
        
    }
}
