namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.2.18. Вызовите сначала метод заполнения данных массива размерности 10,
    /// а потом метод его вывода на экран с сортировкой.
    /// </summary>
    internal class Program
    {
        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];
            for (int i = 0; i < num; i++)
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
        static void ShowArray(int[] array, bool isSort = false)
        {
            var temp = array;
            if (isSort) temp = SortArray(array);
            foreach (int i in temp)
            {
                Console.WriteLine(i);
            }
        }
        public static void Main(string[] args)
        {
            var array = GetArrayFromConsole(10);
            ShowArray(array, true);
        }
    }
}