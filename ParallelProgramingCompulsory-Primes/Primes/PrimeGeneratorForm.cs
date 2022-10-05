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
                Debug.WriteLine(time);
                //
                // Display the results:
                //
                
                this.PrimesList.BeginUpdate();
                
                this.timeTextBox.Text = time;
                PrimesList.Items.AddRange(new object[] { primesFound });
                /*
                foreach (var prime in primesFound)
                {
                    this.PrimesList.Items.Add(prime);
                }*/

                this.PrimesList.EndUpdate();
                

            }

        }

        private async void btnGetPrimesParallel_Click(object sender, EventArgs e)
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

                List<long> primesFound = await Task.Factory.StartNew(() => primeGenerator.GetPrimesParallel(fromInputlong, toInputlong));

                sw.Stop();

                string time = String.Format("{0:f3} sec.", sw.Elapsed.TotalSeconds);
                Debug.WriteLine(time);
                //
                // Display the results:
                //
                
                this.PrimesList.BeginUpdate();

                this.timeTextBox.Text = time;
                /*
                foreach (var prime in primesFound)
                {
                    this.PrimesList.Items.Add(prime);
                }
                */


                this.PrimesList.Items.AddRange(new object[]{"System.Windows.Forms",
        "System.Drawing", "System.Xml", "System.Net", "System.Runtime.Remoting",
        "System.Web"});

                this.PrimesList.EndUpdate();

            }
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

        private void PrimesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}