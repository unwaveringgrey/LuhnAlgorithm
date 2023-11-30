var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => ProgrammingPractice.TestFiles.LuhnAlgorithm.Main(new string[0]));

app.Run();
