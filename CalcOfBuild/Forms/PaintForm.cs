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
    public partial class PaintForm : Form
    {
        public PaintForm()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a = Convert.ToSingle(textBox1.Text);
            double b = Convert.ToSingle(textBox2.Text);
            double c = Convert.ToSingle(textBox3.Text);
            double d = Convert.ToSingle(textBox4.Text);
            double f = Convert.ToSingle(textBox5.Text);
            double g = Convert.ToSingle(textBox6.Text);
            double h = Convert.ToSingle(textBox7.Text);

            double s = d * f;
            double sDO = s - g - h;
            double obshRasch = sDO * a;
            double obshLitrj = obshRasch * b;
            double obshBank = obshLitrj / c;

            obshLitrj = Math.Ceiling(obshLitrj);
            obshBank = Math.Ceiling(obshBank);

            label12.Text = Convert.ToString(obshLitrj);
            label13.Text = Convert.ToString(obshBank);

            StreamWriter sw = new StreamWriter("D:\\PaintHistory.txt");

            sw.WriteLine("Расход краски на 1 м^2(кг): " + textBox1.Text, " Кол-во слоёв на окрас: " + textBox2.Text, " Объём банки(л): " + textBox3.Text);
            sw.WriteLine("Высота комнаты(м): " + textBox4.Text, " Периметр стен(м): " + textBox5.Text, " Площадь дверей(м^2): " + textBox6.Text, " Площадь окон(м^2): " + textBox7.Text);
            sw.WriteLine("Итого:");
            sw.WriteLine("Всего краски(кг): " + label12.Text);
            sw.WriteLine("Всего банок: " + label13.Text);
            sw.Close();

        }


    }
}
