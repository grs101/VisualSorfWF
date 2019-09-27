using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualSorfWF
{
    public partial class ChoiceForm : Form
    {
        Main m1;
        public ChoiceForm()
        {
            InitializeComponent();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

            }
            else if(radioButton2.Checked)
            {
                m1 = new Main();
                m1.Show();
            }
        }
    }
}
