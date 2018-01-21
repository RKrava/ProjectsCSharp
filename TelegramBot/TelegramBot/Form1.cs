using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelegramBot;

namespace TelegramBot
{
    public partial class MainForm : Form
    {
        BackgroundWorker bw;

        public MainForm()
        {
            InitializeComponent();
            this.bw = new BackgroundWorker();
            this.bw.DoWork += this.bw_DoWork;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void BtnRunClick(object sender, EventArgs e)
        {
            var text = txtKey.Text; 
            if (this.bw.IsBusy != true)
            {
                this.bw.RunWorkerAsync(text); 
            }
        }

        async void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            var key = e.Argument as String; 
            try
            {
                var Bot = new Telegram.Bot.TelegramBotClient(key); 
                await Bot.SetWebhookAsync("");
                int offset = 0; 
                while (true)
                {
                    var updates = await Bot.GetUpdatesAsync(offset); 

                    foreach (var update in updates) 
                    {
                        var message = update.Message;
                        if (message.Type == Telegram.Bot.Types.Enums.MessageType.TextMessage)
                        {
                            if (message.Text == "/saysomething")
                            {
                                await Bot.SendTextMessageAsync(message.Chat.Id, "тест",
                                       replyToMessageId: message.MessageId);
                            }
                        }
                        offset = update.Id + 1;
                    }

                }
            }
            catch (Telegram.Bot.Exceptions.ApiRequestException ex)
            {
                Console.WriteLine(ex.Message); 
            }

        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            var text = txtKey.Text;
            if (this.bw.IsBusy != true)
            {
                this.bw.RunWorkerAsync(text);
            }
        }
    }
}
