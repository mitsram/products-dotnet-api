using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Microsoft.VisualBasic;
using Products.Application;
using Products.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddPresentation()
        .AddApplication()
        .AddInfrastructure();
    builder.Services.AddControllers();
    builder.Services.AddSwaggerGen(options => {
        var info = new OpenApiInfo{ Title = "My Api", Version = "v1" };
        options.SwaggerDoc(name: "v1", info: info);
    }
    );
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    
    app.Run();
}
