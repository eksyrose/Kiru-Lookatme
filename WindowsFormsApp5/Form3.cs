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
    public partial class Form3 : Form
    {
        string town_id = "";
        public Form3(string town, string t_id)
        {
            InitializeComponent();
            town_id = t_id;
            labelMain.Text = "Введите данные о заявке для города " + town + ":";
            textBox3.Text = "День города";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox1.Text = monthCalendar1.SelectionStart.Year.ToString();
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.ToString() != ""))
            { 
              //  try
               // {
                    DataBase.Work("INSERT INTO public.zayavki (zayavka_id, town_id, year, date, prazdnik, status_dati, " +
                        "status_zayavki, podacha_s, gas_razreshen, kogda_proverit, dlina_prazdnika, arenda, lpr) " +
                        "VALUES (DEFAULT, '" + town_id + "', '" + textBox1.Text.ToString() + "', "
                        + "'" + textBox2.Text.ToString() + "', "
                        + "'" + textBox3.Text.ToString() + "', "
                        + "'" + comboBox1.Items[comboBox1.SelectedIndex].ToString()/*textBox4.Text.ToString()*/ + "', "
                        + "'" + textBox5.Text.ToString() + "', "
                        + "'" + textBox6.Text.ToString() + "', "
                        + "'" + comboBox2.Items[comboBox1.SelectedIndex].ToString()/*textBox7.Text.ToString()*/ + "', "
                        + "'" + textBox8.Text.ToString() + "', "
                        + "'" + textBox9.Text.ToString() + "', "
                        + "'" + textBox10.Text.ToString() + "', "
                        + "'" + textBox11.Text.ToString() + "');");
                    DialogResult = DialogResult.OK;
                    this.Close(); //закрываем форму
             //   }
             //   catch { }
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.Year.ToString();
            textBox2.Text = monthCalendar1.SelectionStart.ToShortDateString().Substring(0, 5);//monthCalendar1.SelectionStart.Day.ToString() + monthCalendar1.SelectionStart.Month.ToString();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.Year.ToString();
            textBox2.Text = monthCalendar1.SelectionStart.ToShortDateString().Substring(0, 5);//monthCalendar1.SelectionStart.Day.ToString() + monthCalendar1.SelectionStart.Month.ToString();
        }
    }
}
