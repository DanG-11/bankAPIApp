using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace bankAPIApp
{
    public partial class Login : Form
    {

        frmRachunek Rachunek;

        public Login(frmRachunek p)
        {
            Rachunek = p;
            InitializeComponent();
        }

        private void PrzyciskZalogujWcisniety(object sender, EventArgs e)
        {
            string login = txtBoxEMail.Text;
            string haslo = txtBoxHaslo.Text;

            HttpClient client = new HttpClient();
            string url = "http://localhost/bankAPI/login";
            var data = new LoginRequestClass(login, haslo);
            HttpResponseMessage odpowiedz = client.PostAsJsonAsync(url, data).Result;
            string json = odpowiedz.Content.ReadAsStringAsync().Result;
            TokenRequestClass token = JsonConvert.DeserializeObject<TokenRequestClass>(json);
            Rachunek.token = token.token;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PrzyciskWyjdzKlikniety(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
