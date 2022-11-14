using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using POJOS;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Bot
{
    class Program
    {
        private static readonly TelegramBotClient botClient = new TelegramBotClient("1084470537:AAHNQibxcTeETpv5W5RL2H_lflNBtlS6Cds");

        static void Main(string[] args)
        {
            botClient.OnMessage += Bot_OnMessage;
            botClient.OnCallbackQuery += BotOnCallbackQueryReceived;
            botClient.OnReceiveError += BotOnReceiveError;
            botClient.StartReceiving();
            Console.ReadLine();
            botClient.StopReceiving();
        }

        private async static void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            var message = e.Message;

            await botClient.SendChatActionAsync(message.Chat.Id, ChatAction.Typing);

            await Task.Delay(50);

            var lstBtn = new List<InlineKeyboardButton[]>();

            var lstExchangesRates = await GetAllExchangeRate();

            foreach (var exchange in lstExchangesRates)
            {
                var btn = new[]
                {
                    InlineKeyboardButton.WithCallbackData(
                        text:exchange.Key.ToShortDateString(),
                        callbackData: exchange.Key.ToString("yyyy-MM-dd"))
                };
                lstBtn.Add(btn);
            }

            var keyboard_Uno = new InlineKeyboardMarkup(lstBtn);

            await botClient.SendTextMessageAsync(e.Message.Chat.Id, "Elija una opción: ", replyMarkup: keyboard_Uno);
        }

        private static async Task<Dictionary<DateTime, ExchangeRate>> GetAllExchangeRate()
        {
            var url = "https://localhost:44334/api/ExchangeRate";
            var client = new HttpClient { BaseAddress = new Uri(url) };
            var responseMessage = await client.GetAsync(url, HttpCompletionOption.ResponseContentRead);
            var resultAsync = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Dictionary<DateTime,ExchangeRate>>(resultAsync);
            return result;
        }

        private static async void BotOnCallbackQueryReceived(object sender, CallbackQueryEventArgs callbackQueryEventArgs)
        {
            var callbackQuery = callbackQueryEventArgs.CallbackQuery;

            var er = GetExchangeRate(callbackQuery.Data).Result;

            await botClient.SendTextMessageAsync(
                chatId: callbackQuery.Message.Chat.Id,
                text: "El tipo de cambio es: " + er.Valor
            );

        }

        private static async Task<ExchangeRate> GetExchangeRate(string date)
        {
            var url = "https://localhost:44334/api/ExchangeRate?dateRequest=" + date + "";
            var client = new HttpClient { BaseAddress = new Uri(url) };
            var responseMessage = await client.GetAsync(url, HttpCompletionOption.ResponseContentRead);
            var resultAsync = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ExchangeRate>(resultAsync);
            return result;
        }

        private static void BotOnReceiveError(object sender, ReceiveErrorEventArgs receiveErrorEventArgs)
        {
            Console.WriteLine("Received error: {0} — {1}",
                receiveErrorEventArgs.ApiRequestException.ErrorCode,
                receiveErrorEventArgs.ApiRequestException.Message);
        }
    }
}
