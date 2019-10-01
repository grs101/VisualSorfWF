using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace VisualSorfWF
{
    class Draw
    {
        public static int speed = 0;
        static BufferedGraphics buffered;

        public static void begin(ref PictureBox picBox, int [] array, int max)
        {
            drawMarking(ref picBox);
            drawSort(ref picBox, array, max);
            buffered.Render();
            buffered.Dispose();
            Thread.Sleep(speed);
        }

        //Отрисовка линий в клетку
        static void drawMarking(ref PictureBox picBox)
        {
            buffered = BufferedGraphicsManager.Current.Allocate(picBox.CreateGraphics(), picBox.DisplayRectangle);
            Pen pen = new Pen(Color.Green);
            buffered.Graphics.Clear(Color.White);
            for (int i = 0; i < picBox.Height; i += 15)
                buffered.Graphics.DrawLine(pen, 0, picBox.Height - i, picBox.Width, picBox.Height - i);
            for (int i = 0; i < picBox.Width; i += 15)
                buffered.Graphics.DrawLine(pen, i, 0, i, picBox.Width);
        }

        //Отрисовка сортировки
        static void drawSort(ref PictureBox picbox, int[] array, int max)
        {
            bool flag = true;
            Pen pen = new Pen(Color.DarkOrange);
            for (int i = 0; i <= max; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (flag)
                        pen = new Pen(Color.DarkOrange);
                    else
                        pen = new Pen(Color.Green);
                    flag = !flag;

                    if (array[j] >= i)
                        buffered.Graphics.FillRectangle(new SolidBrush(pen.Color), 15 * j, picbox.Height - 15 * i, 15, 15);
                }
                if (array.Length % 2 != 0)
                    flag = !flag;
            }
        }
    }
}
