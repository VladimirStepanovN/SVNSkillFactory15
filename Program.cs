namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.5.5. Выполните метод, чтобы посчитать факториал 20. Что отобразится на экране?
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(20));
        }
        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }
}