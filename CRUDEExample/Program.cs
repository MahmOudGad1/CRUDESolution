var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

if(app.Environment.IsDevelopment())
{
app.UseDeveloperExceptionPage();

}

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
app.Run();
