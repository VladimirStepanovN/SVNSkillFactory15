namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.3.3. Добавьте слово ref в метод ChangeName перед именем параметра.
    /// Обратите внимание, что это слово нужно указать и в вызове метода.
    /// </summary>
    internal class Program
    {
        static void ChangeAge(ref int age)
        {
            age++;
            Console.WriteLine($"Возраст после изменения: {age}");
        }
        public static void Main(string[] args)
        {
            int myAge = 34;
            ChangeAge(ref myAge);
            Console.WriteLine($"Мой возраст: {myAge}");
        }
    }
}