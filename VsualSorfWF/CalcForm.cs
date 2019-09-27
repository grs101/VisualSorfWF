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
    public partial class CalcForm : Form
    {
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
    }
}
