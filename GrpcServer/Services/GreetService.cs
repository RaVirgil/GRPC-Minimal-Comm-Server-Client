using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class GreetService : Greet.GreetBase
    {
        public override Task<EmptyMessage> PrintClientInput(ClientInputRequest request, ServerCallContext context)
        {
            Console.WriteLine("Hello "+request.Name+"!");
            return Task.FromResult(new EmptyMessage());

        }
    }
}
