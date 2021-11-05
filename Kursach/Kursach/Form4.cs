using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Ваш заказ оформлен.");
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }


    }
}
