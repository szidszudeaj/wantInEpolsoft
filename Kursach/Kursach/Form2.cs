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
    public partial class Form2 : Form
    {
        Guitar g1 = new Guitar("Fender CD-60S", 570, "Китай", true, "Аккустическая", "4/4");
        Guitar g2 = new Guitar("Yamaha C40", 351, "Индонезия", true, "Классическая", "4/4");
        Guitar g3 = new Guitar("Cort AD810SSB", 340.6, "Индонезия", true, "Аккустическая", "4/4");
        Piano p1 = new Piano("Casio Celviano AP-470BN", 2877.42, "Китай", true, 88);
        Piano p2 = new Piano("Medeli SP3000+stand", 1104.58, "Китай", true, 88);
        Piano p3 = new Piano("Casio Celviano AP-470BN", 3401.32, "Китай", true, 88);
        MixingConsoles mc1 = new MixingConsoles("Novation Launchpad Pro MK3", 439.4, "Китай", true, "MIDI контроллер",3);
        MixingConsoles mc2 = new MixingConsoles("Pioneer DDJ-XP2", 2521.51, "Китай", true, "DJ контроллер",4);
        MixingConsoles mc3 = new MixingConsoles("Numark Party Mix", 280.8, "Китай", true, "DJ контроллер",2);

        List<Instrument> Basket = new List<Instrument>();



        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(g2.Info());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(g1.Info());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(g3.Info());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p1.Info());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p2.Info());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p3.Info());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mc1.Info());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mc2.Info());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mc3.Info());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Basket.Add(g1);
            MessageBox.Show("Товар успешно добавлен!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Basket.Add(g2);
            MessageBox.Show("Товар успешно добавлен!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Basket.Add(g3);
            MessageBox.Show("Товар успешно добавлен!");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Basket.Add(p1);
            MessageBox.Show("Товар успешно добавлен!");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Basket.Add(p2);
            MessageBox.Show("Товар успешно добавлен!");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Basket.Add(p3);
            MessageBox.Show("Товар успешно добавлен!");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Basket.Add(mc1);
            MessageBox.Show("Товар успешно добавлен!");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Basket.Add(mc2);
            MessageBox.Show("Товар успешно добавлен!");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Basket.Add(mc3);
            MessageBox.Show("Товар успешно добавлен!");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

 

        private void button22_Click(object sender, EventArgs e)
        {
            if (Basket.Count == 0)
            {
             MessageBox.Show("Вы не можете офрмить заказ с пустой карзиной!");   
            }
            else
            {
                int h = 0;// оплата
                int r = 0;//доставка
                this.Hide();
                Form4 f3 = new Form4();

                if (radioButton1.Checked)
                    h = 1;
                if (radioButton2.Checked)
                    h = 2;
                if (radioButton6.Checked)
                    h = 3;
                if (radioButton4.Checked)
                    r = 1;
                if (radioButton3.Checked)
                    r = 2;
                if (radioButton5.Checked)
                    r = 3;
                if (radioButton6.Checked)
                {
                    installment pay = new installment(Basket, 12);
                    f3.label2.Text = pay.Info(h, r);
                }
                else
                {
                    Payment pay = new Payment(Basket);
                    f3.label2.Text = pay.Info(h, r);
                }
                f3.ShowDialog();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string s = " ";
            for (int i = 0; i < Basket.Count; i++)
                s = s + $"{Basket[i].Name} \n";
            MessageBox.Show(s);

        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            Basket.Clear();
        }
    }
}
