namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chooseOperation.Items.Add("+");
            chooseOperation.Items.Add("-");
            chooseOperation.Items.Add("*");
            chooseOperation.Items.Add("/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonNormalize_Click(object sender, EventArgs e)
        {
            int[] arr = ViewModel.Normalize(int.Parse(normalizeNumerator.Text), int.Parse(normalizeDenominator.Text));
            normalizeNumerator.Text = arr[0].ToString();
            normalizeDenominator.Text = arr[1].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr = ViewModel.fromDec(double.Parse(fromDec.Text));
            fromDecNumerator.Text = arr[0].ToString();
            fromDecDenominator.Text = arr[1].ToString();
        }

        private void toDecButton_Click(object sender, EventArgs e)
        {
            double num = ViewModel.toDec(int.Parse(toDecNumerator.Text), int.Parse(toDecDenominator.Text));
            toDecResult.Text = num.ToString();
            Console.WriteLine(num.ToString());
        }

        private void execMathOperButton_Click(object sender, EventArgs e)
        {
            string operation = chooseOperation.Text;
            int numerator1 = int.Parse(mathNumerator1.Text);
            int numerator2 = int.Parse(mathNumerator2.Text);
            int denominator1 = int.Parse(mathDenominator1.Text);
            int denominator2 = int.Parse(mathDenominator2.Text);
            int[] arr = ViewModel.DoMath(numerator1, denominator1, numerator2, denominator2, operation);
            mathNumeratorOut.Text = arr[0].ToString();
            mathDenominatorOut.Text = arr[1].ToString();
        }   
    }
}
