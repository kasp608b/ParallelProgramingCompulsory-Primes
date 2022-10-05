using System.Diagnostics;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
                //clear the display
                this.timeTextBox.Text = "";

                this.PrimesList.Items.Clear();

                //Calculate results
                long fromInputlong = long.Parse(fromInput.Text);
                long toInputlong = long.Parse(toInput.Text);

                Stopwatch sw = Stopwatch.StartNew();

                List<long> primesFound = await Task.Factory.StartNew(() => primeGenerator.GetPrimesSequential(fromInputlong, toInputlong));

                sw.Stop();

                string time = String.Format("{0:f3} sec.", sw.Elapsed.TotalSeconds);

                //
                // Display the results:
                //

                this.PrimesList.BeginUpdate();

                this.timeTextBox.Text = time;

                foreach (var prime in primesFound)
                {
                    this.PrimesList.Items.Add(prime);
                }

                this.PrimesList.EndUpdate();

            }

        }

        private void btnGetPrimesParallel_Click(object sender, EventArgs e)
        {
        }

        private Task<Boolean> DisplayAsync(string time, List<long> primesFound)
        {
            return Task.Run<Boolean>(() => Display(time, primesFound));

        }

        private Boolean Display(string time, List<long> primesFound)
        {
            this.timeTextBox.Text = time;

            foreach (var prime in primesFound)
            {
                this.PrimesList.Items.Add(prime);
            }

            return true;

        }



    }
}