namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.2.15. Вызовите метод GetArrayFromConsole, не указывая необязательный параметр.
    /// Результат работы метода должен быть в переменной array.
    /// Передайте эту переменную в метод SortArray, а результат этого метода сохраните в переменной sortedarray.
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
        static string ShowColor(string name, int age) => Console.ReadLine();
        public static void Main(string[] args)
        {
            var array = GetArrayFromConsole();
            var sortedarray = SortArray(array);
        }
    }
}