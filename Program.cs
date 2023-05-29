namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.2.7. Внесите корректировки в код вывода ваших параметров на экран так,
    /// чтобы имя и возраст выводились одной строкой, а "Напишите свой любимый цвет" — другой.
    /// </summary>
    internal class Program
    {
        static string ShowColor(string name, int age) => Console.ReadLine();
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
                Console.WriteLine("{0}, {1} лет \nНапишите свой любимый цвет на английском с маленькой буквы", anketa.name, anketa.age);
                favcolors[i] = ShowColor(anketa.name, anketa.age);
            }
            foreach (string favcolor in favcolors)
            {
                Console.WriteLine(favcolor);
            }
            Console.ReadKey();
        }
    }
}