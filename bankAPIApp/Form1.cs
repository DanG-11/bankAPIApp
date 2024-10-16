using Newtonsoft.Json;

namespace bankAPIApp
{
    public partial class frmRachunek : Form
    {
        public frmRachunek()
        {
            InitializeComponent();
        }

        private void GetAccountData(object sender, EventArgs e)
        {
            //to jest blibioteka do wysy³ania zapytañ http
            //i przetwarzania odpowiedzi otrzymanych z API
            HttpClient klient = new HttpClient();
            //adres API
            string url = "http://localhost/bankAPI/account/";
            //dopisz numer konta z textboxa do adresu API
            url += txtBoxNrRachunku.Text;
            //wysy³amy zapytanie GET do API
            HttpResponseMessage odpowiedz = klient.GetAsync(url).Result;
            //wyci¹gnij z odpowiedzi dane w formacie JSON
            string json = odpowiedz.Content.ReadAsStringAsync().Result;
            Account konto = JsonConvert.DeserializeObject<Account>(json);
            //wypisz dane na formularzu
            grpBoxLblNazwaRachunku.Text = konto.name;
            grpBoxLblNrRachunku.Text = konto.accountNo.ToString();
            grpBoxLblKwotaNaRachunku.Text = konto.amount.ToString();
        }

        private void OnAppLoad(object sender, EventArgs e)
        {
            Login loginForm = new Login();
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
