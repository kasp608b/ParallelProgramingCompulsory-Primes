namespace Primes
{
    public partial class Form : System.Windows.Forms.Form
    {
        PrimeGenerator primeGenerator = new PrimeGenerator();
        public Form()
        {
            InitializeComponent();
        }
        private async void btnGetPrimesSequential_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fromInput.Text) && !string.IsNullOrWhiteSpace(toInput.Text))
            { 
                /*

            List<long> PrimesFound = await Task.Factory.StartNew(() => primeGenerator.GetPrimesSequential());
                */
            }

        }

        private void btnGetPrimesParallel_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {/*
            if (!string.IsNullOrWhiteSpace(fromInput.Text) && !PrimesList.Items.Contains(fromInput.Text))
                PrimesList.Items.Add(fromInput.Text);*/
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}