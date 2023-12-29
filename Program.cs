var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.AddPersistence();

var app = builder.Build();

app.MapUsuariosEndpoints();

app.UseSwagger();
app.UseSwaggerUI(c => {});

app.Run();
