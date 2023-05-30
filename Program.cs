namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.3.8. Необходимо передать по ссылке размерность массива
    /// в метод GetArrayFromConsole и изменить её на 6.
    /// </summary>
    internal class Program
    {
        static int[] GetArrayFromConsole(ref int num)
        {
            num = 6;
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
            int num = 5;
            var array = GetArrayFromConsole(ref num);
            ShowArray(array, true);
            Console.WriteLine($"Значение размера массива после изменения {num}");
        }
    }
}