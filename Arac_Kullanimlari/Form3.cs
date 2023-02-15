using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(maskedTextBox1.Text + " " + maskedTextBox2.Text + " " + maskedTextBox3.Text + " " + maskedTextBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(dateTimePicker1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ad:" + " " + textBox1.Text);
            listBox1.Items.Add("Soyad:" + " " + textBox2.Text);
            listBox1.Items.Add("TC:" + " " + maskedTextBox2.Text);
            listBox1.Items.Add("Telefon:" + " " + maskedTextBox1.Text);
            listBox1.Items.Add("Şehir:" + " " + comboBox1.Text);
            listBox1.Items.Add("Doğum Tarihi:" + " " + dateTimePicker1.Text);
        }

    }
}
