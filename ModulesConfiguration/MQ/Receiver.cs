using System;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

class Receiver
{
  public static void Receive()
  {
    var factory = new ConnectionFactory() { HostName = "localhost" };
    string eventRaised = "ModuleSettingsChange";

    using (var connection = factory.CreateConnection())    
    using (var channel = connection.CreateModel())
    {
      channel.ExchangeDeclare(exchange: eventRaised, type: "fanout");

      var queueName = channel.QueueDeclare().QueueName;
      channel.QueueBind(queue: queueName, exchange: eventRaised, routingKey: "");

      Console.WriteLine(" [*] Waiting for logs.");

      var consumer = new EventingBasicConsumer(channel);
      consumer.Received += (model, ea) =>
      {
        var body = ea.Body;
        var message = Encoding.UTF8.GetString(body);
        Console.WriteLine(" [x] {0}", message);
      };
      channel.BasicConsume(queue: queueName, autoAck: true, consumer: consumer);

      Console.WriteLine(" Press [enter] to exit.");
      Console.ReadLine();
    }
  }
}
