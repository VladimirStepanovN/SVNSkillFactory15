namespace SVNSkillFactory15
{
    /// <summary>
    /// Задание 5.6. Итоговый проект
    #region Описание задания 5.6.
    ///Необходимо создать метод, который заполняет данные с клавиатуры по пользователю (возвращает кортеж):
    ///Имя;
    ///Фамилия;
    ///Возраст;
    ///Наличие питомца;
    ///Если питомец есть, то запросить количество питомцев;
    ///Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив
    ///их кличек(заполнение с клавиатуры);
    ///Запросить количество любимых цветов;
    ///Вызвать метод, который возвращает массив любимых цветов по их количеству(заполнение с клавиатуры);
    ///Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев,
    ///количество цветов в отдельном методе;
    ///Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
    ///Корректный ввод: ввод числа типа int больше 0.
    ///Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
    ///Вызов методов из метода Main.
    #endregion
    /// </summary>
    internal class Program
    {
        //------метод, который заполняет данные с клавиатуры по пользователю (возвращает кортеж)---
        private static (string name, string lastName, int age, bool isHavePet) GetUserInfo()
        {
            (string name, string lastName, int age, bool isHavePet) user;
            Console.Write("Введите ваше имя: ");
            user.name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            user.lastName = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            while (!CheckNum(Console.ReadLine(), out user.age))
            {
                Console.Write("Введите ваш возраст корректно: ");
            }
            Console.Write("У вас есть домашние животные: ");
            user.isHavePet = "да".Equals(Console.ReadLine().ToLower());
            return user;
        }
        //-----------------------------------------------------------------------------------------
        //-----метод, принимающий на вход количество питомцев и возвращающий массив их кличек------
        private static string[] GetPetNames(int countPets)
        {
            string[] petNames = new string[countPets];
            for (int i = 0; i < countPets; i++)
            {
                Console.Write($"Введите имя питомца №{i}: ");
                petNames[i] = Console.ReadLine();
            }
            return petNames;
        }
        //-----------------------------------------------------------------------------------------
        //------------метод, который возвращает массив любимых цветов по их количеству-------------
        private static string[] GetColorNames(int countColors)
        {
            string[] colorNames = new string[countColors];
            for (int i = 0; i < countColors; i++)
            {
                Console.Write($"Введите название любимого цвета №{i}: ");
                colorNames[i] = Console.ReadLine();
            }
            return colorNames;
        }
        //-----------------------------------------------------------------------------------------
        //------------------проверка, ввёл ли пользователь корректные числа------------------------
        private static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return true;
                }
            }
            {
                corrnumber = 0;
                return false;
            }
        }
        //-----------------------------------------------------------------------------------------
        //---------------Метод, который принимает кортеж и показывает на экран данные--------------
        private static void ShowUserInfo((string name, string lastName, int age, bool isHavePets) userInfo,
           string[] colorNames, params string[] petNames)
        {
            Console.WriteLine($"Ваше имя: {userInfo.name}.");
            Console.WriteLine($"Ваша фамилия: {userInfo.lastName}.");
            Console.WriteLine($"Ваш возраст: {userInfo.age}.");
            if (userInfo.isHavePets)
            {
                Console.WriteLine($"У вас есть {petNames.Length} домашних животных. Их зовут: ");
                foreach (string petName in petNames)
                {
                    Console.WriteLine(petName);
                }
            }
            else
            {
                Console.WriteLine("У вас нет домашних животных.");
            }
            Console.WriteLine($"У вас {colorNames.Length} любимых цветов. Их названия:");
            foreach (string colorName in colorNames)
            {
                Console.WriteLine(colorName);
            }
        }
        //-----------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            var userInfo = GetUserInfo();
            string[] petNames;
            int countPets = 0;
            string[] colorNames;
            if (userInfo.isHavePet)
            {
                Console.Write("Какое количество у вас домашних животных: ");
                while (!CheckNum(Console.ReadLine(), out countPets))
                {
                    Console.Write("Введите количество корректно: ");
                }
                petNames = GetPetNames(countPets);
            }
            else
            {
                petNames = new string[countPets];
            }
            Console.Write("Сколько у вас любимых цветов: ");
            int countColors;
            while (!CheckNum(Console.ReadLine(), out countColors))
            {
                Console.Write("Введите количество корректно: ");
            }
            colorNames = GetColorNames(countColors);
            if (countPets > 0)
            {
                ShowUserInfo(userInfo, colorNames, petNames);
            }
            else
            {
                ShowUserInfo(userInfo, colorNames);
            }
        }
    }
}