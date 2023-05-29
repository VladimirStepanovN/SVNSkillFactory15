namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.1.6. Модифицируйте метод из скринкаста:
    /// после ввода массива с клавиатуры необходимо отсортировать массив и вывести его на экран. 
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
        static int[] SortByInsertion(int[] source)
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
        public static void Main(string[] args)
        {
            int[] result = SortByInsertion(GetArrayFromConsole());
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}