var builder = DistributedApplication.CreateBuilder(args);

var cache = builder
    .AddRedis("cache")
    .WithDataVolume();

var mongoDb = builder
    .AddMongoDB("mongodb")
    .WithDataVolume();

var rabbitMQ = builder
    .AddRabbitMQ("rabbitmq")
    .WithManagementPlugin()
    .WithDataVolume();

var sqlServer = builder
    .AddSqlServer("controk")
    .WithDataVolume();

builder.AddProject<Projects.StockApi>(nameof(Projects.StockApi))
    .WithExternalHttpEndpoints()
    .WithReference(rabbitMQ)
    .WithReference(sqlServer
        .AddDatabase("sqlserver:stock", "StockDB"));

builder.AddProject<Projects.Web>(nameof(Projects.Web))
    .WithExternalHttpEndpoints()
    .WithReference(cache);

builder.AddProject<Projects.SagaOrchestrator>(nameof(Projects.SagaOrchestrator))
    .WithReference(rabbitMQ)
    .WithReference(mongoDb.AddDatabase("mongodb", "sagas"));

builder.Build().Run();
