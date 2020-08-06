using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sortings.ShellSort shellSort = new Sortings.ShellSort();
            Sortings.QuickSort quickSort = new Sortings.QuickSort();

            var startTimeShell = System.Diagnostics.Stopwatch.StartNew();
            var startTimeQuick = System.Diagnostics.Stopwatch.StartNew();

            int maxElements = 100000;
            int step = 10;

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            for (int i = 10; i <= maxElements; i *= step)
            {
                //Запускаем таймер
                startTimeShell.Restart();
                shellSort.GetShellSort(GenerateRandomArray(i));
                //Останавливаем таймер и выводим время для Шелла
                startTimeShell.Stop();

                startTimeQuick.Restart();
                quickSort.GetQuickSort(GenerateRandomArray(i));
                startTimeQuick.Stop();

                chart1.Series[0].Points.AddXY(startTimeShell.Elapsed.TotalMilliseconds, i);
                chart1.Series[1].Points.AddXY(startTimeQuick.Elapsed.TotalMilliseconds, i);
            }
        }

        private int[] GenerateRandomArray(int arrayLength)
        {
            Random random = new Random();

            int[] randomArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
                randomArray[i] = random.Next(arrayLength);

            return randomArray;
        }
    }
}
