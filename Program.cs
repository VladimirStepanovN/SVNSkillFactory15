namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.3.1. Создайте метод ChangeAge, в который передадите свой возраст.
    /// Измените его и выведите на экран исходное значение вне метода.
    /// </summary>
    internal class Program
    {
        static void ChangeAge(int age)
        {
            age++;
            Console.WriteLine($"Возраст после изменения: {age}");
        }
        public static void Main(string[] args)
        {
            int myAge = 34;
            ChangeAge(myAge);
            Console.WriteLine($"Мой возраст: {myAge}");
        }
    }
}