using Microsoft.OpenApi.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMvc();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseRouting();
        app.UseHttpsRedirection();
        app.MapControllers();

        //if (app.Environment.IsDevelopment())
        //{
            app.UseSwagger();
            app.UseSwaggerUI();
        //}


        app.Run();
    }
}
