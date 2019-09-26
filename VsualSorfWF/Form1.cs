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

            if (MyThread1 != null)
            {
                if (!MyThread1.IsAlive)
                {
                    switch (comboBox1.SelectedIndex)
                    {
                        case 0:
                            {
                                MyThread1 = new Thread(delegate ()
                                {
                                    BubbleSort.begin(array, ref pictureBox1, min, max);
                                });
                                MyThread1.Start();
                                break;
                            }
                        case 1:
                            {
                                MyThread1 = new Thread(delegate ()
                                {
                                    HeapSort.begin(array, ref pictureBox1, min, max);
                                });
                                MyThread1.Start();
                                break;
                            }
                        case 2:
                            {
                                MyThread1 = new Thread(delegate ()
                                {
                                    InsertSort.begin(array, ref pictureBox1, min, max);
                                });
                                MyThread1.Start();
                                break;
                            }
                        case 3:
                            {
                                MyThread1 = new Thread(delegate ()
                                {
                                    QuickSort.begin(array, ref pictureBox1, 0, array.Length - 1, min, max);
                                });
                                MyThread1.Start();
                                break;
                            }
                        case 4:
                            {
                                MyThread1 = new Thread(delegate ()
                                {
                                    SelectionSort.begin(array, ref pictureBox1, min, max);
                                });
                                MyThread1.Start();
                                break;
                            }
                    }
                }
            }
            else
            {
                
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        {
                            MyThread1 = new Thread(delegate ()
                            {
                                BubbleSort.begin(array, ref pictureBox1, min, max);
                            });
                            MyThread1.Start();
                            break;
                        }
                    case 1:
                        {
                            MyThread1 = new Thread(delegate ()
                            {
                                HeapSort.begin(array, ref pictureBox1, min, max);
                            });
                            MyThread1.Start();
                            break;
                        }
                    case 2:
                        {
                            MyThread1 = new Thread(delegate ()
                            {
                                InsertSort.begin(array, ref pictureBox1, min, max);
                            });
                            MyThread1.Start();
                            break;
                        }
                    case 3:
                        {
                            MyThread1 = new Thread(delegate ()
                            {
                                QuickSort.begin(array, ref pictureBox1, 0, array.Length - 1, min, max);
                            });
                            MyThread1.Start();
                            break;
                        }
                    case 4:
                        {
                            MyThread1 = new Thread(delegate ()
                            {
                                SelectionSort.begin(array, ref pictureBox1, min, max);
                            });
                            MyThread1.Start();
                            break;
                        }
                }
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
    }
}