
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//
builder.Services.AddControllers();
builder.Services.AddAuthentication();
//PersonContext added as a scoped (default of method AddDbContext) service:
builder.Services.AddDbContext<ModelContext>(options => 
                options.UseNpgsql(builder.Configuration.GetConnectionString("DBConnection")));  //connection string in appsettings 

//builder.Services.AddDbContext<PersonContext>(); //in this case the connection string has to appear in the OnConfiguring method
//builder.Services.AddTransient<IPersonStorage, TextFilesPersonStorage>();
builder.Services.AddOptions();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//Middleware to print the endpoint requested on Console
app.Use(async (context, next) =>
{
  await next.Invoke();
  Console.WriteLine($"{context.Request.Path} was requested");
});

app.Run(); 






