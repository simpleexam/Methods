using System.IO.Pipes;
using static System.Console;
namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //результат генерации массива сохраняется в переменную Result, т.к. есть возвращаемое значение
            int[] result = GenerateArray(10);

            //метод-процедура просто вызывается без сохранения результата
            PrintArray(result, '/');




        }
        /// <summary>
        /// Генирирует одномерный массив целых чисел
        /// </summary>
        /// <param name="len">длина будущего массива</param>
        /// <returns>массив</returns>
        static int[] GenerateArray (int len)
        {
            int[] array = new int[len];
            Random random = new Random();
            for(int i = 0; i<len; i++)
            {
                array[i] = random.Next(0, 10);
            }
            return array; //обязателен возврат из метода типа в соответсвтии с сигнатурой
        }

        /// <summary>
        /// вывод на консоль одномерного массива
        /// </summary>
        /// <param name="array">массив для вывода</param>
        /// <param name="separator">разделитель для элементов</param>
        static void PrintArray(int[] array, char separator)
        {
            foreach(int item in array)
            {
                Console.Write($"{item}{separator}");
            }
        }
       



    }
}
