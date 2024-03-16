namespace _2_ChangeRegistry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            //т.к. метод Zabor() возвращает строку, можно метод вызвать в качестве аргумента при выводе на консоль
            Console.WriteLine(Zabor(inputText));
        }

        /// <summary>
        /// возврат строки забором (изменение регистра)
        /// </summary>
        /// <param name="text">исходная строка</param>
        /// <returns>строка заборчиком</returns>
        static string Zabor(string text)
        {
            char[] result = text.ToCharArray(); // преобразование строки в массив символов

            for (int i = 0; i< result.Length; i++)
            {
                if (i%2==0)
                    result[i] = Char.ToUpper(result[i]); 
                else
                    result[i]= Char.ToLower(result[i]);
            }
            return String.Join("", result); //возврат строки, сгенерированной из массива символов
        }
    }
}
