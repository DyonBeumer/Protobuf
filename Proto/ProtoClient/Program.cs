using System.Threading.Tasks;
using Grpc.Net.Client;
using ProtoClient;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:5001");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "ProtoClient" });
Console.WriteLine("HelloRequest Response message: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();