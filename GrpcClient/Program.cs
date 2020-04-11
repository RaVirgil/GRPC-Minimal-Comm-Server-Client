using Grpc.Net.Client;
using GrpcServer;
using System;

namespace GrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greet.GreetClient(channel);
            Console.WriteLine("Whats your name? ");
            string name = Console.ReadLine();
            var request = new ClientInputRequest { Name = name };
            Console.WriteLine(client.PrintClientInput(request));
            Console.ReadLine();

        }
    }
}
