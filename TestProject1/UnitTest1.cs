namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEncodedStringNotSame()
        {
            string testString = "боб";

            Assert.IsTrue(GetCodedString(testString) != testString);
        }

        [TestMethod]
        public void IsEncodedStringLengthSame()
        {
            string testString = "боб";

            Assert.IsTrue(GetCodedString(testString).Length == testString.Length);
        }

        private string GetCodedString(string uncoded)
        {
            int nomer; // Номер в алфавите
            int d; // Смещение
            string s; //Результат
            int j; // Переменная для циклов

            char[] massage = uncoded.ToCharArray(); // Превращаем строку в массив символов.

            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            // Перебираем каждый символ сообщения
            for (int i = 0; i < massage.Length; i++)
            {
                // Ищем индекс буквы
                for (j = 0; j < alfavit.Length; j++)
                {
                    if (massage[i] == alfavit[j])
                    {
                        break;
                    }
                }

                if (j != 33) // Если j равно 33, значит символ не из алфавита
                {
                    nomer = j; // Индекс буквы
                    d = nomer + 3; // Делаем смещение

                    // Проверяем, чтобы не вышли за пределы алфавита
                    if (d > 32)
                    {
                        d = d - 33;
                    }

                    massage[i] = alfavit[d]; // Меняем букву
                }
            }

            return new string(massage); // Собираем символы обратно в строку.
        }
    }
}