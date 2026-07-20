using Confluent.Kafka;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafkaChatWindows
{
    public partial class Form1 : Form
    {
        private readonly string bootstrap = "localhost:9092";
        private readonly string topic = "chat-message";

        public Form1()
        {
            InitializeComponent();

            Task.Run(StartConsumer);
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = bootstrap
            };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            await producer.ProduceAsync(topic,
                new Message<Null, string>
                {
                    Value = txtMessage.Text
                });

            txtMessage.Clear();
        }

        private void StartConsumer()
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = bootstrap,
                GroupId = "windows-chat",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer =
                new ConsumerBuilder<Ignore, string>(config).Build();

            consumer.Subscribe(topic);

            while (true)
            {
                var result = consumer.Consume();

                Invoke(new Action(() =>
                {
                    lstMessages.Items.Add(result.Message.Value);
                }));
            }
        }
    }
}