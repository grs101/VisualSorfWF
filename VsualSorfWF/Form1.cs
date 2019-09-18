using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace VsualSorfWF
{
    public partial class Form1 : Form
    {
        private BufferedGraphics buffered;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array;

            Random random = new Random();
            array = new int[(int)countElements.Value];
            array = array.Select(x => random.Next((int)minLim.Value, (int)(maxLim.Value + 1))).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                SelectionSort.begin(ref array, i);

                drawMarking();
                drawSort(array);
                buffered.Render();
                buffered.Dispose();
                Thread.Sleep(10);
            }
        }

        private void drawSort(int[] array)
        {
            bool flag = true;
            Pen pen = new Pen(Color.DarkOrange);
            for (int i = (int)minLim.Value; i <= maxLim.Value; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (flag)
                        pen = new Pen(Color.DarkOrange);
                    else
                        pen = new Pen(Color.Green);
                    flag = !flag;

                    if (array[j] >= i)
                        buffered.Graphics.FillRectangle(new SolidBrush(pen.Color), 15 * j, pictureBox1.Height - 15 * i, 15, 15);
                }
                if(array.Length % 2 != 0)
                    flag = !flag;
            }
        }

        private void drawMarking()
        {
            buffered = BufferedGraphicsManager.Current.Allocate(pictureBox1.CreateGraphics(), pictureBox1.DisplayRectangle);
            Pen pen = new Pen(Color.Green);
            buffered.Graphics.Clear(Color.White);
            for (int i = 0; i < pictureBox1.Height; i += 15)
                buffered.Graphics.DrawLine(pen, 0, pictureBox1.Height - i, pictureBox1.Width, pictureBox1.Height - i);
            for (int i = 0; i < pictureBox1.Width; i += 15)
                buffered.Graphics.DrawLine(pen, i, 0, i, pictureBox1.Width);
        }
        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            drawMarking();
            buffered.Render();
        }
    }
}