using ChuckNorrisAPI;

namespace ChuckDoesNotPlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGenerateJoke_Click(object sender, EventArgs e)
        {
            var getJoke = await ChuckNorrisClient.GetRandomJoke();
            lblDisplayJoke.Text = getJoke.JokeText;
        }


        private async void chooseYourPoison()
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach (var cat in categories)
            {
                cmbJokeCategories.Items.Add(cat);
            }
            cmbJokeCategories.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chooseYourPoison();
        }
    }
}