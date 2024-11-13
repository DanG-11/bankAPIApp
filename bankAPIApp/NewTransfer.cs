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

namespace bankAPIApp
{
    public partial class NewTransfer : Form
    {

        public string token;
        public string source;

        public NewTransfer()
        {
            InitializeComponent();
        }

        private void NewTransfer_Load(object sender, EventArgs e)
        {
            TxtBoxRachunekZrodlowy.Text = source;
        }

        private void BtnWykonajPrzelew_Click(object sender, EventArgs e)
        {
            string target = TxtBoxRachunekDocelowy.Text;
            float userAmount = float.Parse(TxtBoxKwota.Text);
            int amount = Convert.ToInt32(Math.Round(userAmount * 100));
            var data = new {token = token, target = target, amount = amount};
            string url = "http://localhost/bankAPI/transfer/new";
            HttpClient client = new HttpClient();
            HttpResponseMessage odpowiedz = client.PostAsJsonAsync(url, data).Result;

            if(odpowiedz.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Przelew wykonany pomyślnie.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Błąd podczas wykonywania przelewu");
            }
        }
    }
}
