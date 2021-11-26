using System;

namespace Lib_14
{
    public class Practic
    {
        /// <summary>
        /// Вычисляет сумму целых случайных чисел, распределенных в диапазоне от 55 до 70 ,пока эта сумма не превышает некоторого числа K
        /// </summary>
        /// <param name="userNumber">число которое не должно быть превышено</param>
        /// <param name="numberList">сгенерированые числа в строковой форме "1 2 3 4 ..."</param>
        /// <param name="counterNumbers">количество сгенеррованых чисел</param>
        /// <param name="sum">сумма сгенерированых чисел</param>
        public static void SumNumbers(int userNumber, out int counterNumbers, out int sum, out string numberList)
        {
            numberList = "";
            sum = 0;           
            counterNumbers = 0;
            int newNumber;
            Random randomNumber = new Random();
            while (sum < userNumber)
            {
                newNumber = randomNumber.Next(55, 70);//Рандомные числа
                if ((sum + newNumber) < userNumber)
                {
                    sum += newNumber;//Вычисление суммы
                    counterNumbers++;//Счетчик
                    numberList += Convert.ToString(newNumber) + " ";//Заполнение строки числа
                }
                else break;
            }
        }
    }
}
