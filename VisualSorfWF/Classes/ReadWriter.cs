using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace VisualSorfWF
{
    class ReadWriter
    {
        //чтение данных из файла
        public int [] readData (OpenFileDialog openFileDialog, ref ComboBox comboBox1)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return null;
                string filename = openFileDialog.FileName; //получаем файл
                int[] arrayLine = System.IO.File.ReadAllText(filename).Split(new char[] { ',', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                return arrayLine;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверный формат строки");
            }
            catch
            {
                MessageBox.Show("Внутренняя ошибка");
            }
            return null;
        }
        public void writeData (ref SaveFileDialog saveFileDialog1, ref int [] array)
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
                    foreach (int elem in array)
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
    }
}
