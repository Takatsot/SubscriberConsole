using System;
using System.Collections.Generic;
using System.Text;
using IQBusinessSubscriberConsole.Configurations;
using RabbitMQ.Client;

namespace Subscriber.Subscriber.SL
{
    public class SubscriberLogic
    {
        #region Sending Input string to RabbitMQ queue

        /// <summary>
        /// Sends the Input String to RabbitMQ Queue
        /// </summary>
        /// <param name="InputString"></param>

        public void SendInputString (string InputString)
        {
            try
            {
                SendToQueue(InputString);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message.ToString());
            }
           
        }

        /// <summary>
        /// Sends the Input String to RabbitMQ Queue
        /// </summary>
        /// <param name="Name"></param>
        private void SendToQueue(string Name)
        {
            try
            {
                var factory = new ConnectionFactory() { HostName = BusConstants.HostName };
                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: BusConstants.Queue, durable: false, exclusive: false, autoDelete: false, arguments: null);

                    string message = "Hello My name is, {0}" + Name;
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "", routingKey: BusConstants.routingKey, basicProperties: null, body: body);

                    Console.WriteLine(" [x] Sent {0}", message);
                }

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message.ToString());
            }

        }

        #endregion
    }
}
