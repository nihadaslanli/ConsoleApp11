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
            user.Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("password yaz:");
            user.Password = Console.ReadLine();


            Console.WriteLine($"username: {user.Username} userage:{user.Age}userpasword:{user.Password}");
        }
    }
}
