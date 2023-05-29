namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.1. Создайте кортеж User, содержащий имя пользователя Name
    /// и массив с текстовой информацией о его пяти любимых блюдах Dishes. 
    /// Заполните имя пользователя через ввод в консоль, а информацию о блюдах — в цикле через консоль.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            Console.Write("Введите ваше имя: ");
            User.Name = Console.ReadLine();
            User.Dishes = new string[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($@"Введите название любимого блюда №{i + 1}");
                User.Dishes[i] = Console.ReadLine();
            }
            Console.WriteLine($@"Ваше имя {User.Name}");
            Console.WriteLine("Ваши любимые блюда:");
            foreach(string Dishes in User.Dishes)
            {
                Console.WriteLine(Dishes);
            }
            Console.ReadKey();
        }
    }
}