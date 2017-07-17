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
            // todo: проверить на непустые
            
            //создаём новую запись, используя данные из textbox-ов
              //добавляем запись в документ
            this.Close(); //закрываем форму
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //закрываем форму
        }
        
    }
}
