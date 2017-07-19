using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.ToString() != "") && (textBox2.ToString() != "") && (textBox3.ToString() != "") &&
                (textBox4.ToString() != "") && (textBox5.ToString() != "") && (textBox6.ToString() != "") &&
                (textBox7.ToString() != ""))
            {
                try
                {
                    DataBase.Work("INSERT INTO public.towns (town_id, town, oblast, znachenie, rayon, administration, " +
                        "chislennost, rasstoyanie, coordinates) VALUES (DEFAULT, '" + textBox1.ToString() + "', "
                        + "'" + textBox2.ToString() + "', "
                        + "'" + textBox3.ToString() + "', "
                        + "'" + textBox4.ToString() + "', "
                        + "'" + textBox5.ToString() + "', "
                        + "'" + textBox6.ToString() + "', "
                        + "'" + textBox7.ToString() + "', "
                        + "'" + textBox8.ToString() + "');");
                    this.Close(); //закрываем форму
                }
                catch
                { }
                //создаём новую запись, используя данные из textbox-ов
                //добавляем запись в документ
            }
            else MessageBox.Show("Заполните все ячейки со звёздочкой!", "Невозможно добавить запись");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //закрываем форму
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
