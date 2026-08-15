namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        int second = 0;
        int minute = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second += 1;
            if (second >= 60)
            {
                minute += 1;
                second = 0;
            }
            label1.Text = second.ToString();
            label2.Text = minute.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            second = 0;
            minute = 0;
            label1.Text = second.ToString();
            label2.Text = minute.ToString();
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

