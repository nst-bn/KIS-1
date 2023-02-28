using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //отчёт продаж
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e) //договора
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }
        //Nastya/price
        //bibuniyTstCmmit
        private void button3_Click(object sender, EventArgs e) //закгрузить прайс-лист
        {
            Form4 form4 = new Form4(this);
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e) //анализ потребности
        {
            Form5 form5 = new Form5(this);
            form5.Show();
        }

        private void button5_Click(object sender, EventArgs e) //расчёт потребности
        {
            Form6 form6 = new Form6(this);
            form6.Show();
        }

        private void button6_Click(object sender, EventArgs e) //расстановка приоритетов
        {
            Form7 form7 = new Form7(this);
            form7.Show();
        }
    }
   
}
