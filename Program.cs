namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.2.3. Измените код Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы").
    /// Необходимо добавить переменную username, которая будет отображена в начале текста.
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
                Console.WriteLine("{0} Напишите свой любимый цвет на английском с маленькой буквы", anketa.name);
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