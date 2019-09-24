using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

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
            Random random = new Random();

            int count = (int)countElements.Value;
            int min = (int)minLim.Value;
            int max = (int)(maxLim.Value + 1);
            int [] array = new int[count];
            array = array.Select(x => random.Next(min, max)).ToArray();
            Thread MyThread1 = new Thread(delegate () {
                InsertSort.begin(array, ref pictureBox1, min, max);
            });
            MyThread1.Start();
        }
    }
}