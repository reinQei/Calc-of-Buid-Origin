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
    public partial class FormTilesdCalc : Form
    {
        public FormTilesdCalc()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',')
                e.Handled = true;
        }


        private void CalcTile_Click(object sender, EventArgs e)
        {
            //считывание текст боксов
            double a = Convert.ToSingle(textBox1.Text);
            double b = Convert.ToSingle(textBox2.Text);
            double c = Convert.ToSingle(textBox3.Text);
            double d = Convert.ToSingle(textBox4.Text);
            double e1 = Convert.ToSingle(textBox5.Text);
            double f = Convert.ToSingle(textBox6.Text);
            double g = Convert.ToSingle(textBox7.Text);
            double h = Convert.ToSingle(textBox8.Text);
            double i = Convert.ToSingle(textBox9.Text);
            double j = Convert.ToSingle(textBox10.Text);

            //плитка
            double oneplit = ((a + 0.125) * (b + 0.125)) / 10000;
            double ed1m = 1 / oneplit;

            //двери
            double okn = ((e1 * f) / 10000) * g;

            double dver = ((h * i) / 1000) * j;

            //стены
            double sten = (c * d) - okn - dver;

            //кол-во плитки
            double s = ed1m * sten;
            s = Math.Ceiling(s);

            //вывод
            label12.Text = Convert.ToString(s);

            string ed1mStr = Convert.ToString(ed1m);
            string stenStr = Convert.ToString(sten);

            StreamWriter sw = new StreamWriter("D:\\TilesHistory.txt");

            sw.WriteLine("Размер плитки по X(cм): " + textBox1.Text, " Размер плитки по Y(cм): " + textBox2.Text);
            sw.WriteLine("Площадь укладки по X(м): " + textBox3.Text, " Площадь укладки по Y(м): " + textBox4.Text);
            sw.WriteLine("Размер дверей по X(см): " + textBox5.Text, " Размер дверей по Y(см) " + textBox6.Text, " Кол-во таких двере: " + textBox7.Text);
            sw.WriteLine("Размер окон по X(см) " + textBox8.Text, " Размер окон по Y: " + textBox9.Text, " Кол-во таких окон: " + textBox10.Text);
            sw.WriteLine("Итого:");
            sw.WriteLine("Плитки на 1м: " + ed1mStr);
            sw.WriteLine("Общее кол-во плитки на: " + stenStr, " Надо: " + label12.Text + " плитки ");
            sw.Close();

        }


    }
}
