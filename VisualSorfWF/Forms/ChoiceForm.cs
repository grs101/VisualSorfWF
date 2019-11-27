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
        Main mf1; //экземпляр формы визуализации
        CalcForm cf1; //экземпляр формы расчетов
        public ChoiceForm()
        {
            InitializeComponent();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cf1 = new CalcForm();
                this.Hide();
                cf1.Show();
            }
            else if(radioButton2.Checked)
            {
                mf1 = new Main();
                this.Hide();
                mf1.Show();
            }
        }

        //полный выход из программы при закрытии приложения
        private void ChoiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
