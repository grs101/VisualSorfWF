using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace VisualSorfWF
{
    public partial class CalcForm : Form
    {
        Thread MyThread1;

        private static int[] array;

        public CalcForm()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
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
                int minim = (int)min.Value;
                int maxim = (int)max.Value;
                if (!radioButton2.Checked)
                {
                    array = new int[(int)count.Value];
                    FillArray.generate_rand_data_for_array(ref array, (int)count.Value, minim, maxim);
                }
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

        //Открывает файл и загружает данные из него
        private void openFileButton_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            array = new ReadWriter().readData(openFileDialog1, ref comboBox1);
        }

        //Сохраняет в файл данные
        private void saveFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;
                string line = array.ToString();
                // сохраняем текст в файл
                using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Default))
                {
                    foreach(int elem in array)
                    {
                        sw.Write(elem + " ");
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выберите данные для сортировки");
            }
            catch
            {
                MessageBox.Show("Внутренняя ошибка");
            }
        }

        //выход назад в меню выбора
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChoiceForm().Show();
        }
    }
}
