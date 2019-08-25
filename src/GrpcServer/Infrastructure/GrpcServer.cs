using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Hosting;
using Services.Messages;


namespace GrpcServer.Infrastructure
{
    public class GrpcServer : BackgroundService
    {
        private Server _server;
        
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            const string host = "localhost";
            const int port = 50000;
            _server = new Server
            {
                Services = {GrpcMessageService.BindService(new GrpcServiceHost())},
                Ports = {new ServerPort(host, port, ServerCredentials.Insecure)}
            };
            _server.Start();

            return Task.CompletedTask;
        }

        public override Task StopAsync(CancellationToken cancellationToken)
            => _server.ShutdownAsync();
    }
}