using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using Services.Messages;

namespace GrpcClient
{
    class Program
    {
        private static GrpcMessageService.GrpcMessageServiceClient _client;
        
        static async Task Main(string[] args)
        {
            const string host = "localhost";
            const int port = 50000;

            Console.WriteLine("Starting a client...");

            var channel = new Channel($"{host}:{port}", ChannelCredentials.Insecure);
            _client = new GrpcMessageService.GrpcMessageServiceClient(channel);

            Console.WriteLine("Client has started.");

           var response = _client.GetMessage(new GetMessageRequest {Id = "lol"});
           Console.WriteLine(response.Id);
           Console.WriteLine(response.Value1);
           Console.WriteLine(response.Value2);

           var stream = _client.GetMessagesStream(new GetMessageRequest {Id = "lol"});
           
           while (await stream.ResponseStream.MoveNext(CancellationToken.None))
           {
               Console.WriteLine(stream.ResponseStream.Current.Id);
           }

           Console.WriteLine(stream.GetStatus());
        }
    }
}