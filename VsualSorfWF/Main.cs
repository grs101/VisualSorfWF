using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace VisualSorfWF
{
    public partial class Main : Form
    {
        static int[] array;
        Thread MyThread1;
        public Main()
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
            array = new int[count];
            array = array.Select(x => random.Next(min, max)).ToArray();
            if (MyThread1 != null)
            {
                if (!MyThread1.IsAlive) //проверка на выполнение потока. Не запускать, если он запущен
                {
                    //главный запуск
                    start(ref pictureBox1, ref comboBox1, ref MyThread1, min, max);
                }
            }
            else
            {
                //главный запуск
                start(ref pictureBox1, ref comboBox1, ref MyThread1, min, max);
            }
        }

        //остановка процесса сортировки
        private void button2_Click(object sender, EventArgs e)
        {
            MyThread1.Abort();
        }

        //загрузка по умолчанию при запуске формы
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = comboBox1.Items[0];
        }
        //запуск сортировки с передачей ссылок на picturebox и combobox
        static void start(ref PictureBox p, ref ComboBox c, ref Thread t, int min, int max)
        {
            PictureBox p1 = p; //создаю копию на ссылку picturebox, чтобы передать в Thread
            switch (c.SelectedIndex)
            {
                case 0:
                    {
                        t = new Thread(delegate ()
                        {
                            BubbleSort.begin(array, ref p1, min, max);
                        });
                        t.Start();
                        break;
                    }
                case 1:
                    {
                        t = new Thread(delegate ()
                        {
                            HeapSort.begin(array, ref p1, min, max);
                        });
                        t.Start();
                        break;
                    }
                case 2:
                    {
                        t = new Thread(delegate ()
                        {
                            InsertSort.begin(array, ref p1, min, max);
                        });
                        t.Start();
                        break;
                    }
                case 3:
                    {
                        t = new Thread(delegate ()
                        {
                            QuickSort.begin(array, ref p1, 0, array.Length - 1, min, max);
                        });
                        t.Start();
                        break;
                    }
                case 4:
                    {
                        t = new Thread(delegate ()
                        {
                            SelectionSort.begin(array, ref p1, min, max);
                        });
                        t.Start();
                        break;
                    }
            }
        }

        //полный выход из окна/программы
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}