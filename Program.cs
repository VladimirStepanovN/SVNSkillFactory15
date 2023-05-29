namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.2.2. Добавьте код из юнита 4.4 (Задание 4.4.2),
    /// который получает данные пользователя, и исправьте метод ShowColor,
    /// ему необходимо передать поле name кортежа. 
    /// </summary>
    internal class Program
    {
        static string ShowColor(string name) => Console.ReadLine();
        public static void Main(string[] args)
        {
            (string name, int age) anketa;
            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);
            string[] favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine($@"Напишите свой любимый цвет №{i + 1} на английском с маленькой буквы");
                favcolors[i] = ShowColor(anketa.name);
            }
            foreach (string favcolor in favcolors)
            {
                Console.WriteLine(favcolor);
            }
            Console.ReadKey();
        }
    }
}