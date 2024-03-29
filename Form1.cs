namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            // Show Form2
            form3.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();
        }
    }
}
