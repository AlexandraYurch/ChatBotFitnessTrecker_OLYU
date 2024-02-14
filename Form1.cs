using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;

namespace ChatBotFitnessTrecker_OLYU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TelegramBotClient botClient;
        private void Form1_Load(object sender, EventArgs e)
        {
            botClient = new TelegramBotClient("");

        }
        public async Task StartReceiver()
        {
            var token = new CancellationTokenSource();
            var cancelToken = token.Token;
            var ReOpt = new ReceiverOptions { AllowedUpdates = { } };
            await botClient.ReceiveAsync(OnMessage, ErrorMessage, ReOpt, cancelToken);
        }
        public async Task OnMessage(ITelegramBotClient botClient, Update update, CancellationToken cancellation)
        {
            if(update.Message is Message message)
            {

            }
        }
    }
}