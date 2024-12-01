using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using MatrimonialApi.CommonEntity;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;

namespace MatrimonialApi.Utilities
{
  /// <summary>
    /// Represents a service for interacting with a queue.
    /// </summary>
    public class QueueService
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;


        /// <summary>
        /// Initializes a new instance of the <see cref="QueueService"/> class.
        /// </summary>
        /// <param name="configuration">The configuration instance to read settings from.</param>

        public QueueService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("AzureQueueStorage");
            _configuration= configuration;
        }

        /// <summary>
        /// Enqueues an email message to the queue.
        /// </summary>
        /// <param name="emailMessage">The email message to enqueue.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task EnqueueEmailAsync(EmailMessage emailMessage)
        {
            string _queueName = _configuration.GetSection("QueueName").Value;
            // Create a QueueClient
            QueueClient queueClient = new QueueClient(_connectionString, _queueName);

            // Create the queue if it doesn't already exist
            await queueClient.CreateIfNotExistsAsync();

            if (await queueClient.ExistsAsync())
            {
                // Serialize the email message to JSON
                string messageJson = JsonConvert.SerializeObject(emailMessage);

                // Base64 encode the message
                string base64Message = Convert.ToBase64String(Encoding.UTF8.GetBytes(messageJson));

                // Send the message to the queue
                await queueClient.SendMessageAsync(base64Message);
            }
        }
    }
}
