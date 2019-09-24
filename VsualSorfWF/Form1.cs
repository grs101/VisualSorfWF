using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace VisualSorfWF
{
    public partial class Form1 : Form
    {
        Thread MyThread1;
        public Form1()
        {
            InitializeComponent();
        }

        //кнопка запуска сортировки
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int count = (int)countElements.Value;
            int min = (int)minLim.Value;
            int max = (int)(maxLim.Value + 1);
            int [] array = new int[count];
            array = array.Select(x => random.Next(min, max)).ToArray();
            MyThread1 = new Thread(delegate () {
                QuickSort.begin(array, ref pictureBox1, 0, array.Length-1, min, max);
            });
            MyThread1.Start();
        }

        //остановка процесса сортировки
        private void button2_Click(object sender, EventArgs e)
        {
            MyThread1.Abort();
        }
    }
}