using System;
using System.Linq;
using System.Windows.Forms;

namespace VisualSorfWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array;
            Random random = new Random();
            int count = (int)countElements.Value;
            int min = (int)minLim.Value;
            int max = (int)(maxLim.Value + 1);
            array = new int[count];
            array = array.Select(x => random.Next(min, max)).ToArray();

            //for (int i = 0; i < array.Length; i++)
            //{
                BubbleSort.begin(array, ref pictureBox1, min, max);
                //Draw.begin(ref pictureBox1, array, min, max);
            //}
        }
    }
}