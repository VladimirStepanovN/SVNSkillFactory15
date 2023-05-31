namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.5.8. Необходимо написать рекурсивный метод,
    /// который возводит введенное число N типа int в указанную степень pow типа byte.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PowerUp(2, 8));
        }
        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0) return 1;
            if (pow > 1)
            {
                return N * PowerUp(N, --pow);
            }
            else
            {
                return N;
            }
        }
    }
}