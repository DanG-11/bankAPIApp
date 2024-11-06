using Newtonsoft.Json;
using System.Net.Http.Json;

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
            string url = "http://localhost/bankAPI/account/details/";
            var data = new { token = token };
            HttpResponseMessage odpowiedz = klient.PostAsJsonAsync(url, data).Result;
            string json = odpowiedz.Content.ReadAsStringAsync().Result;
            Account konto = JsonConvert.DeserializeObject<Account>(json);
            grpBoxTxtBoxNazwaRachunku.Text = konto.name;
            grpBoxTxtBoxNrRachunku.Text = konto.accountNo.ToString();
            grpBoxTxtBoxKwotaNaRachunku.Text = konto.amount.ToString();
        }

        private void OnAppLoad(object sender, EventArgs e)
        {
            Login loginForm = new Login(this);
            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                this.Show();
                GetAccountData(sender, e);
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
