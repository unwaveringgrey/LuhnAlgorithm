internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMvc();

        var app = builder.Build();

        app.UseRouting();
        app.UseHttpsRedirection();
        app.MapControllers();

        app.Run();
    }
}