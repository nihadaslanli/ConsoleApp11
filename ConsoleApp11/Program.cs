namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            User user = new User();
            Console.WriteLine("ad qeyd edin:");
            user.Username = Console.ReadLine();
            Console.WriteLine("yasini qeyd et:");
            user.age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("password yaz:");
            user._Pasword = Console.ReadLine();


            Console.WriteLine(user.Username+user.age+user._Pasword);

            
            
            
        }
    }


     
}
