using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

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
    }
}
