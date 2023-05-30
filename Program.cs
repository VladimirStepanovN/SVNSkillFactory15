namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.2.8. Разделить метод из задания 5.1.6 GetArrayFromConsole() на два:
    /// один метод GetArrayFromConsole() должен читать введенные с клавиатуры массивы и возвращать их,
    /// второй метод SortArray() должен принимать параметром массив array типа данных int,
    /// сортировать его и возвращать.
    /// </summary>
    internal class Program
    {
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        static int[] SortArray(int[] source)
        {
            int outer, inner;
            for (outer = 1; outer < source.Length; outer++)
            {
                int temp = source[outer];
                inner = outer;
                while (inner > 0 && source[inner - 1] >= temp)
                {
                    source[inner] = source[inner - 1];
                    --inner;
                }
                source[inner] = temp;
            }
            return source;
        }
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