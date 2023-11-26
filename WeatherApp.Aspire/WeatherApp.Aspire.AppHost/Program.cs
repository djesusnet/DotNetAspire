var builder = DistributedApplication.CreateBuilder(args);


var cacheRedis = builder.AddRedisContainer("rediscache");

var api = builder.AddProject<Projects.WeatherApp_Api>("weatherapi");

builder.AddProject<Projects.WeatherApp_Web>("frontend")
       .WithReference(api)
       .WithReference(cacheRedis);



builder.Build().Run();
