using System;
using RabbitMQ.Client;
using System.Text;

class Emitter
{
  public static void Emit(string data,string e)
  {
    var factory = new ConnectionFactory() { HostName = "localhost" };
    using (var connection = factory.CreateConnection())
    using (var channel = connection.CreateModel())
    {
      channel.ExchangeDeclare(exchange: e, type: "fanout");

      var message = data;
      var body = Encoding.UTF8.GetBytes(message);
      channel.BasicPublish(exchange: e, routingKey: "", basicProperties: null, body: body);
      Console.WriteLine(" [x] Sent {0}", message);
    }

    Console.WriteLine(" Press [enter] to exit.");
    Console.ReadLine();
  }

  private static string GetMessage(string[] args)
  {
    return ((args.Length > 0) ? string.Join(" ", args) : "info: Hello World!");
  }
}
