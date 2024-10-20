using Controk.SagaOrchestrator.StateInstances;
using Controk.SagaOrchestrator.StateMachines;
using MassTransit;
using MassTransit.Logging;

var builder = WebApplication.CreateBuilder(args);
_ = builder.AddServiceDefaults();

_ = builder.Services.AddMassTransit(options =>
{
    options.SetKebabCaseEndpointNameFormatter();

    options.AddSagaStateMachine<MovementStateMachine, MovementState>()
        .MongoDbRepository(cfg =>
        {
            cfg.Connection = builder.Configuration.GetConnectionString("mongodb");
        });

    options.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host(builder.Configuration.GetConnectionString("rabbitmq"));
        cfg.ConfigureEndpoints(context);
    });
});

_ = builder.Services.AddOpenTelemetry()
    .WithTracing(x => x.AddSource(DiagnosticHeaders.DefaultListenerName));

var app = builder.Build();

app.Run();
