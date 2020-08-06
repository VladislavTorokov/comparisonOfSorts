using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTests
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void ShellSortTest()
        {
            //Создаем произвольный массив
            int[] array = new int[] { 6, 4, 5, 1, 10, 7, 3, 2, 9, 8, 2};

            //Создаем экзепляр класса ShellSort и вызываем метод сортировки массива
            Sortings.Sortings.ShellSort shellSort = new Sortings.Sortings.ShellSort();
            var result = shellSort.GetShellSort(array);

            //Переменная j необходима для проверки чисел массива по порядке от 1 до 10
            int j = 1;
            bool exitFromIf = false;
            for (int i = 0; i < result.Length; i++)
            {
                //Этот блок необходим для повтора цифры 2
                if (j == 2)
                {
                    if (exitFromIf)
                        j++;

                    exitFromIf = true;
                }
                else
                {
                    //Проверка каждого элемента массива
                    Assert.AreEqual(j, result[i]);
                    j++;
                }
            }

        }

        [TestMethod]
        public void QuckSortTest()
        {
            //Создаем произвольный массив
            int[] array = new int[] { 2, 8, 5, 2, 3, 7, 10, 1, 9, 4, 6 };

            //Создаем экзепляр класса QuickSort и вызываем метод сортировки массива
            Sortings.Sortings.QuickSort quickSort = new Sortings.Sortings.QuickSort();
            var result = quickSort.GetQuickSort(array);

            //Переменная j необходима для проверки чисел массива по порядке от 1 до 10
            int j = 1;
            bool exitFromIf = false;

            for (int i = 0; i < result.Length; i++)
            {
                //Этот блок необходим для повтора цифры 2
                if (j == 2)
                {
                    if (exitFromIf)
                        j++;

                    exitFromIf = true;
                }
                else
                {
                    //Проверка каждого элемента массива
                    Assert.AreEqual(j, result[i]);
                    j++;
                }
            }

        }
    }
}
