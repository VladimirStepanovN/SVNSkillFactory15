namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.3.13. Используйте код метода SortArray. 
    /// Сейчас этот метод сортирует массив по возрастанию значения. 
    /// Создайте методы SortArrayDesc и SortArrayAsc — сортировка массива от большего к меньшему
    /// и сортировка массива от меньшего к большему.
    /// Метод SortArray модифицируйте так, чтобы он вызвал оба этих метода.
    /// Результаты методов SortArrayAsc и SortArrayDesc должны представлять собой массивы.
    /// Метод SortArray должен иметь один входной параметр array и два выходных: sorteddesc и sorted asc.
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
        static int[] SortArrayDesc(int[] source)
        {
            int outer, inner;
            for (outer = 1; outer < source.Length; outer++)
            {
                int temp = source[outer];
                inner = outer;
                while (inner > 0 && source[inner - 1] <= temp)
                {
                    source[inner] = source[inner - 1];
                    --inner;
                }
                source[inner] = temp;
            }
            return source;
        }
        static int[] SortArrayAsc(int[] source)
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
        static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            int[] temp1 = new int[array.Length];
            int[] temp2 = new int[array.Length];
            array.CopyTo(temp1, 0);
            array.CopyTo(temp2, 0);
            sorteddesc = SortArrayDesc(temp1);
            sortedasc = SortArrayAsc(temp2);
        }
        static void ShowArray(int[] array, bool isSort = false)
        {
            SortArray(in array, out int[] sorteddesc, out int[] sortedasc);
            Console.WriteLine("Исходный массив:");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Массив sorteddesc:");
            foreach (int i in sorteddesc)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Массив sortedasc:");
            foreach (int i in sortedasc)
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