namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.1.5. Напишите программу, которая в цикле вызывает метод ShowColor(),
    /// записывает его значение в массив из трех цветов favcolors,
    /// а потом отображает значения этого массива. 
    /// </summary>
    internal class Program
    {
        static string ShowColor() => Console.ReadLine();

        public static void Main(string[] args)
        {
            string[] favcolors = new string[3];
            for(int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine($@"Напишите свой любимый цвет №{i + 1} на английском с маленькой буквы");
                favcolors[i] = ShowColor();
            }
            foreach(string favcolor in favcolors)
            {
                Console.WriteLine(favcolor);
            }
            Console.ReadKey();
        }
    }
}