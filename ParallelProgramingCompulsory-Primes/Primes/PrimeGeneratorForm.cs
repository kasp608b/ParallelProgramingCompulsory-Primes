using System.Diagnostics;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Primes
{
    public partial class Form : System.Windows.Forms.Form
    {
        public class Prime
        {
            public Prime(long s)
            {
                _value = s;
            }
            public long Value { get { return _value; } set { _value = value; } }
            long _value;
        }

        PrimeGenerator primeGenerator = new PrimeGenerator();
        List<long> primesFound = new List<long>();
        List<Prime> objectPrimes = new List<Prime>();
        BindingSource listBoxBindingSource = new BindingSource();
        
        public Form()
        {
            InitializeComponent();
            listBoxBindingSource.DataSource = objectPrimes;
            PrimesList.DisplayMember = "Value";
            PrimesList.DataSource = listBoxBindingSource;
            
            

        }
        private async void btnGetPrimesSequential_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fromInput.Text) && !string.IsNullOrWhiteSpace(toInput.Text))
            {
                //clear the display
                this.timeTextBox.Text = "";

                primesFound.Clear();

                //Calculate results
                long fromInputlong = long.Parse(fromInput.Text);
                long toInputlong = long.Parse(toInput.Text);

                Stopwatch sw = Stopwatch.StartNew();

                primesFound = await Task.Factory.StartNew(() => primeGenerator.GetPrimesSequential(fromInputlong, toInputlong));

                foreach (var prime in primesFound) {
                    objectPrimes.Add(new Prime(prime));
                }

                sw.Stop();

                string time = String.Format("{0:f3} sec.", sw.Elapsed.TotalSeconds);

                //
                // Display the results:
                //

                this.timeTextBox.Text = time;


            }

        }

        private async void btnGetPrimesParallel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fromInput.Text) && !string.IsNullOrWhiteSpace(toInput.Text))
            {
                //clear the display
                this.timeTextBox.Text = "";

                primesFound.Clear();

                //Calculate results
                long fromInputlong = long.Parse(fromInput.Text);
                long toInputlong = long.Parse(toInput.Text);

                Stopwatch sw = Stopwatch.StartNew();

                primesFound = await Task.Factory.StartNew(() => primeGenerator.GetPrimesParallel(fromInputlong, toInputlong));
                foreach (var prime in primesFound)
                {
                    objectPrimes.Add(new Prime(prime));
                }

                sw.Stop();

                string time = String.Format("{0:f3} sec.", sw.Elapsed.TotalSeconds);

                //
                // Display the results:
                //

                this.timeTextBox.Text = time;

            }
        }

    }
}