using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using POJOS;

namespace ClientForm
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void metroButton1_Click(object sender, EventArgs e)
        {
            var date = dateTime.Value.ToString("yyyy-MM-dd");
            var url = "https://localhost:44334/api/ExchangeRate";
            var client = new HttpClient { BaseAddress = new Uri(url) };
            var exchangeRateDay = new ExchangeRate();
            exchangeRateDay.Dia = DateTime.Parse(date);
            exchangeRateDay.Valor = Convert.ToDouble(inputExchange.Text);
            var json = JsonConvert.SerializeObject(exchangeRateDay);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync(url, content);
            var resultAsync = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ExchangeRate>(resultAsync);

            exchangeRateValue.Text = result?.Valor.ToString();
        }

        private async void metroButton2_Click(object sender, EventArgs e)
        {
            var date = dateTime.Value.ToString("yyyy-MM-dd");
            var url = "https://localhost:44334/api/ExchangeRate";
            var client = new HttpClient { BaseAddress = new Uri(url) };
            var exchangeRateDay = new ExchangeRate();
            exchangeRateDay.Dia = DateTime.Parse(date);
            exchangeRateDay.Valor = Convert.ToDouble(inputExchange.Text);
            var json = JsonConvert.SerializeObject(exchangeRateDay);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync(url, content);
            var resultAsync = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ExchangeRate>(resultAsync);

            exchangeRateValue.Text = result?.Valor.ToString();
        }

        private async void metroButton3_Click(object sender, EventArgs e)
        {
            var dateRequest = dateTime.Value.ToString("yyyy-MM-dd");
            var url = "https://localhost:44334/api/ExchangeRate?dateRequest=" + dateRequest + "";
            var client = new HttpClient { BaseAddress = new Uri(url) };
            var responseMessage = await client.GetAsync(url, HttpCompletionOption.ResponseContentRead);
            var resultAsync = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ExchangeRate>(resultAsync);

            exchangeRateValue.Text = result?.Valor.ToString();
        }

        private async void metroButton4_Click(object sender, EventArgs e)
        {
            var date = dateTime.Value.ToString("yyyy-MM-dd");
            var url = "https://localhost:44334/api/ExchangeRate/" + date + "";
            var client = new HttpClient { BaseAddress = new Uri(url) };
            var responseMessage = await client.DeleteAsync(url);
            var resultAsync = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ExchangeRate>(resultAsync);

            exchangeRateValue.Text = "Borrado" + result?.Valor.ToString();
        }
    }
}
