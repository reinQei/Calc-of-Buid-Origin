using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CalcOfBuild.Forms
{
    public partial class FormSkirtingBoard : Form
    {
        public FormSkirtingBoard()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a = Convert.ToSingle(textBox1.Text);
            double b = Convert.ToSingle(textBox2.Text);
            double c = Convert.ToSingle(textBox3.Text);

            double uchDver = b - c;
            double dlinPlint = uchDver / a;
            

            dlinPlint = Math.Ceiling(dlinPlint);
            uchDver = Math.Ceiling(uchDver);

            label8.Text = Convert.ToString(dlinPlint);
            label9.Text = Convert.ToString(uchDver);

            StreamWriter sw = new StreamWriter("D:\\SkirtingBoerdHistory.txt");

            sw.WriteLine("Длина 1 плинтуса(м): " + textBox1.Text);
            sw.WriteLine("Периметр комнаты(м): " + textBox2.Text);
            sw.WriteLine("Дверной проём(м): " + textBox3.Text);
            sw.WriteLine("Итого:");
            sw.WriteLine("Общая длина плинтуса(м): " + label8.Text);
            sw.WriteLine("Кол-во плинтуса: " + label9.Text);
            sw.Close();

        }
    }
}
