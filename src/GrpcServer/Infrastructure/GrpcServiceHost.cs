using System.Threading.Tasks;
using Grpc.Core;
using Services.Messages;

namespace GrpcServer.Infrastructure
{
    public class GrpcServiceHost : GrpcMessageService.GrpcMessageServiceBase
    {
        public override Task<GetMessageResponse> GetMessage(GetMessageRequest request, ServerCallContext context)
            => Task.FromResult(new GetMessageResponse
            {
                Id = "Value",
                Value1 = 12,
                Value2 = 12.32
            });

        public override async Task GetMessagesStream(GetMessageRequest request, IServerStreamWriter<GetMessageResponse> responseStream, ServerCallContext context)
        {
            await responseStream.WriteAsync(new GetMessageResponse {Id = "1", Value1 = 1, Value2 = 1});
            await Task.Delay(3000);
            await responseStream.WriteAsync(new GetMessageResponse {Id = "1", Value1 = 1, Value2 = 1});
            await Task.Delay(3000);
            await responseStream.WriteAsync(new GetMessageResponse {Id = "1", Value1 = 1, Value2 = 1});
        }
    }
}