namespace _3_Deposit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //сумма на счете при начальном вкладе 1 млн 10% годовой ставки, 12 месяцев
            Console.WriteLine(GetDepositResult(1000000, 10, 12));

            //сумма на счете при начальном вкладе 10 тыс 10% годовой ставки, 5 месяцев
            Console.WriteLine(GetDepositResult(10000, 10, 5));

        }

        /// <summary>
        /// расчет суммы на счете при применении процентной ставки на определенное количество месяцев
        /// </summary>
        /// <param name="summ">начальная сумма</param>
        /// <param name="persent">годовой процент</param>
        /// <param name="month">количество месяцев</param>
        /// <returns>сумма с капитализацией</returns>
        static double GetDepositResult(double summ, int persent, int month)
        {
            double monthPersent = persent/12.0; //ежемесячный процент
            double result = summ;

            //капитализация каждый месяц
            for (int i = 0; i < month; i++)
            {
                result += result*monthPersent/100.0;
            }
            return result;
        }
    }
}
