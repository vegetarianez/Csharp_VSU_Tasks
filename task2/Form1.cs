using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        ViewModel viewModel = new();
        public Form1()
        {
            InitializeComponent();

            typeField.Items.Add("Самолёт");
            typeField.Items.Add("Вертолёт");
        }

        private void AltitudeField_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypeField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OutputField_TextChanged(object sender, EventArgs e)
        {

        }

        private void TakeOffButton_Click(object sender, EventArgs e)
        {
            string message = viewModel.TakeOff();
            OutputField.Text = message;
        }

        private void LandingButton_Click(object sender, EventArgs e)
        {
            string message = viewModel.Landing();
            OutputField.Text = message;
        }

        private void CreateMachineButton_Click(object sender, EventArgs e)
        {
            viewModel.Create(int.Parse(altitudeField.Text), typeField.Text);
        }
    }
}
