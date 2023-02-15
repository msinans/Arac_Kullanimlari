namespace Arac_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Gençler");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Murat";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Ali";
            label7.Text = "Can";
            label8.Text = "Öðrenci";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // textBox1.Text = "Yazýlým Mühendisliði";

            label9.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label10.Text = textBox2.Text;
            label11.Text = textBox3.Text;
            label12.Text = textBox4.Text;
        }
    }
}