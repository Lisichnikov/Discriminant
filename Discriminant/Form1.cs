namespace Discriminant
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

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double result;

            void Discriminant(double a, double b, double c, out double result)
            {
                result = ((-1) * (b * b)) - (4 * a * c);
            }

            Discriminant(a, b, c, out result);
            label2.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Формула дискриминанта: b^2 - 4ac");
        }
    }
}
