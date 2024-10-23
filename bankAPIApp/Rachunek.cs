using Newtonsoft.Json;

namespace bankAPIApp
{
    public partial class frmRachunek : Form
    {

        public string token;

        public frmRachunek()
        {
            InitializeComponent();
        }

        private void GetAccountData(object sender, EventArgs e)
        {
            HttpClient klient = new HttpClient();
            string url = "http://localhost/bankAPI/account/";
            url += txtBoxNrRachunku.Text;
            HttpResponseMessage odpowiedz = klient.GetAsync(url).Result;
            string json = odpowiedz.Content.ReadAsStringAsync().Result;
            Account konto = JsonConvert.DeserializeObject<Account>(json);
            grpBoxLblNazwaRachunku.Text = konto.name;
            grpBoxLblNrRachunku.Text = konto.accountNo.ToString();
            grpBoxLblKwotaNaRachunku.Text = konto.amount.ToString();
        }

        private void OnAppLoad(object sender, EventArgs e)
        {
            Login loginForm = new Login(this);
            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
