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
            try
            {
                Random random = new Random();
                int count = (int)countElements.Value;
                int min = (int)minLim.Value;
                int max = (int)(maxLim.Value + 1);
                FillArray.generate_rand_data_for_array(ref array, count, min, max);
                if (MyThread1 != null)
                {
                    if (!MyThread1.IsAlive) //проверка на выполнение потока. Не запускать, если он запущен
                    {
                        //главный запуск
                        start(ref pictureBox1, ref comboBox1, array, ref MyThread1, min, max);
                    }
                }
                else
                {
                    //главный запуск
                    start(ref pictureBox1, ref comboBox1, array, ref MyThread1, min, max);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //остановка процесса сортировки
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MyThread1.Abort();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Сначала запустите процесс визуализации");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        //загрузка по умолчанию при запуске формы
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = comboBox1.Items[0];
        }
        //запуск сортировки с передачей ссылок на picturebox и combobox
        public static void start(ref PictureBox p, ref ComboBox c, int[] temp_arr, ref Thread t, int min, int max)
        {
            PictureBox p1 = p; //создаю копию на ссылку picturebox, чтобы передать в Thread
            switch (c.SelectedIndex)
            {
                case 0:
                    {
                        t = new Thread(delegate ()
                        {
                            BubbleSort.begin(ref temp_arr, ref p1, min, max);
                        });
                        t.Start();
                        break;
                    }
                case 1:
                    {
                        t = new Thread(delegate ()
                        {
                            HeapSort.begin(ref temp_arr, ref p1, min, max);
                        });
                        t.Start();
                        break;
                    }
                case 2:
                    {
                        t = new Thread(delegate ()
                        {
                            InsertSort.begin(ref temp_arr, ref p1, min, max);
                        });
                        t.Start();
                        break;
                    }
                case 3:
                    {
                        t = new Thread(delegate ()
                        {
                            QuickSort.begin(ref temp_arr, ref p1, 0, temp_arr.Length - 1, min, max);
                        });
                        t.Start();
                        break;
                    }
                case 4:
                    {
                        t = new Thread(delegate ()
                        {
                            SelectionSort.begin(ref temp_arr, ref p1, min, max);
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
        //действие при закрытии формы
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        //событие перемещения ползунка скролла
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Draw.speed = trackBar1.Value;
            speed_label.Text = trackBar1.Value.ToString() + " ms";
        }
    }
}