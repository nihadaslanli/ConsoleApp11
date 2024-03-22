namespace ConsoleApp11
{
    internal class User
    {
        private string _UserName;
        private int _Age;
        private string _Password;
        public string Username
        {
            get
            {
                return _UserName;
            }


            set
            {
                _UserName = value;
            }
        }
        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine(" yashda - Ola bilmez");

                }

                _Age = value;
            }
        }

        public string Password
        {
            get { return _Password; }
            set
            {
                if (value == null || value.Length == 0)
                {
                    Console.WriteLine("sifre bosh ola bilmez");
                    return;
                }

                if (value.Length < 8)
                {
                    Console.WriteLine("sifre en az 8 simvol uzunluquda olamalidir");
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
                    Console.WriteLine("sifre en az bir boyuk reqem olmalidir");
                    return;
                }

                if (!hasDigit)
                {
                    Console.WriteLine("sifre en az bir reqem olmalidir");
                    return;
                }
                Password = value;
            }
        }
    }
}