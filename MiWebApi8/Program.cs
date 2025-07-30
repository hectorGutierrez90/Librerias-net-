var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // Habilita los servicios para controladores

// Opcional: Para Swagger/OpenAPI (muy recomendable para APIs)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Configura AutoMapper para buscar perfiles en los ensamblajes cargados
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();// Habilita el middleware de Swagger
    app.UseSwaggerUI();// Habilita el UI de Swagger
}

app.UseHttpsRedirection();

app.MapGet("/", context =>
{
    context.Response.Redirect("/swagger");
    return Task.CompletedTask;
});

app.UseRouting(); // Importante para el enrutamiento

app.UseAuthorization();

app.MapControllers(); // Mapea los controladores

app.Run();
