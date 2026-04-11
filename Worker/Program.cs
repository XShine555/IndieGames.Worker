using Infrastructure.MassTransit.DependencyInjection;
using Infrastructure.Persistence;
using Infrastructure.Services;

var builder = Host.CreateApplicationBuilder();
var services = builder.Services;
var configuration = builder.Configuration;

services.AddDatabase(configuration);
services.AddS3Service(configuration);
services.AddPictureService();
services.AddMassTransitConsumer(configuration);

var host = builder.Build();
host.Run();