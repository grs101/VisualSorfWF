using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace VisualSorfWF
{
    public partial class CalcForm : Form
    {
        Thread MyThread1;
        public CalcForm()
        {
            InitializeComponent();
        }

        //действия при запуске формы
        private void CalcForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        //действия при закрытии формы
        private void CalcForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Расчет времени сортировки
        //Вывод в label
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox p1 = null;
                time_sort.Text = null;
                int[] array = new int[(int)count.Value];
                int minim = (int)min.Value;
                int maxim = (int)max.Value;
                FillArray.generate_rand_data_for_array(ref array, (int)count.Value, minim, maxim);
                Stopwatch timer = new Stopwatch();
                timer.Start();
                Main.start(ref p1, ref comboBox1, array, ref MyThread1, minim, maxim);
                MyThread1.Join();
                timer.Stop();
                time_sort.Text += timer.ElapsedMilliseconds + " ms";
            }
            catch
            {
                MessageBox.Show("Ошибка. Недостаточно памяти или неверный диапазон");
            }
        }
    }
}
