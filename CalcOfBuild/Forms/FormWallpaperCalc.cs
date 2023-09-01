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
    public partial class FormWallpaperCalc : Form
    {
        public FormWallpaperCalc()
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
            double d = Convert.ToSingle(textBox4.Text);
            double f = Convert.ToSingle(textBox5.Text);

            double oneDlin = a / d;
            double uchPod = a - (oneDlin * c);

            double oneShir = f / b;

            double obshDlin = oneShir * d;
            double kolvRull = obshDlin / uchPod;

            obshDlin = Math.Ceiling(obshDlin);
            kolvRull = Math.Ceiling(kolvRull);

            label10.Text = Convert.ToString(obshDlin);
            label11.Text = Convert.ToString(kolvRull);

            string ucPodStr = Convert.ToString(uchPod);

            StreamWriter sw = new StreamWriter("D:\\WallpaperHistory.txt");

            sw.WriteLine("Длина рулонна(м): " + textBox1.Text, " Ширина рулонна(м) " + textBox2.Text, "Подгон обоев по картинке(м):" + textBox3.Text);
            sw.WriteLine("Высота комнаты(м): " + textBox4.Text, " Периметр комнаты " + textBox5.Text);
            sw.WriteLine("Итого:");
            sw.WriteLine("Кол-во полос побоев на 1 рулон(м): " + ucPodStr);
            sw.WriteLine("Общая длина обоев(м): " + label10.Text);
            sw.WriteLine("Кол-во рулоннов: " + label11.Text);
            sw.Close();
            
        }
        
    }
}
