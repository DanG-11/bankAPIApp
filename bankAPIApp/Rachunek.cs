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
            AccountRequestClass konto = JsonConvert.DeserializeObject<AccountRequestClass>(json);
            grpBoxTxtBoxNazwaRachunku.Text = konto.name;
            grpBoxTxtBoxNrRachunku.Text = konto.accountNo.ToString();
            grpBoxTxtBoxKwotaNaRachunku.Text = konto.amount.ToString();
            StsStripLblToken.Text = Convert.ToString(token);
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

        private void BtnPrzejdzDoPrzelewow_Click(object sender, EventArgs e)
        {
            NewTransfer newTransfer = new NewTransfer();

            newTransfer.token = token;
            newTransfer.source = grpBoxTxtBoxNazwaRachunku.Text;

            newTransfer.ShowDialog();
        }
    }
}
