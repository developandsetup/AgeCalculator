using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            

            var age = today.Year - dateTimePicker1.Value.Year;
            var month = today.Month - dateTimePicker1.Value.Month;
            var day = (today.Day + dateTimePicker1.Value.Day) - 21;

            if (dateTimePicker1.Value.Date > today.AddYears(-age)) age--;
            textBox1.Text = Convert.ToString(age);
            textBox2.Text = Convert.ToString(month);
            textBox3.Text = Convert.ToString(day);
        }
    }
}
