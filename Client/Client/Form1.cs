using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Client
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private async void requestExchangeRate_Click(object sender, EventArgs e)
        {
            var dateRequest = dateTime.Value.ToString("yyyy-MM-dd");
            var url = "https://localhost:44306/api/ExchangeRate?dateRequest="+dateRequest+"";
            var client = new HttpClient { BaseAddress = new Uri(url) };
            var responseMessage = await client.GetAsync(url, HttpCompletionOption.ResponseContentRead);
            var resultAsync = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ApiResponsev2>(resultAsync);

            exchangeRateValue.Text = result?.Valor.ToString();

        }

        private async void metroButton1_Click(object sender, EventArgs e)
        {
            var date = dateTime.Value.ToString("yyyy-MM-dd");
            var url = "https://localhost:44306/api/ExchangeRate";
            var client = new HttpClient { BaseAddress = new Uri(url) };
            var exchangeRateDay = new ApiResponsev2();
            exchangeRateDay.Dia = date;
            exchangeRateDay.Valor = Convert.ToDouble(inputExchange.Text);
            var json = JsonConvert.SerializeObject(exchangeRateDay);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync(url, content);
            var resultAsync = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ApiResponsev2>(resultAsync);

            exchangeRateValue.Text = result?.Valor.ToString();

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var date = dateTime.Value.ToString("yyyy-MM-dd");
            var url = "https://localhost:44306/api/ExchangeRate";
            var client = new HttpClient { BaseAddress = new Uri(url) };
            var exchangeRateDay = new ApiResponsev2();
            exchangeRateDay.Dia = date;
            exchangeRateDay.Valor = Convert.ToDouble(inputExchange.Text);
            var json = JsonConvert.SerializeObject(exchangeRateDay);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync(url, content);
            var resultAsync = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ApiResponsev2>(resultAsync);

            exchangeRateValue.Text = result?.Valor.ToString();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var date = dateTime.Value.ToString("yyyy-MM-dd");
            var url = "https://localhost:44306/api/ExchangeRate/"+date+"";
            var client = new HttpClient { BaseAddress = new Uri(url) };
            var responseMessage = await client.DeleteAsync(url);
            var resultAsync = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ApiResponsev2>(resultAsync);

            exchangeRateValue.Text = "Borrado" + result?.Valor.ToString();
        }
    }
}
