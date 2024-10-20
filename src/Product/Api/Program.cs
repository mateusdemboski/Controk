var builder = WebApplication.CreateBuilder(args);

_ = builder.AddServiceDefaults();

_ = builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    _ = app
        .UseSwagger()
        .UseSwaggerUI();
}

_ = app.UseHttpsRedirection();

app.Run();
