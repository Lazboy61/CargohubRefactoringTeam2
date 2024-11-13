
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//
builder.Services.AddControllers();
builder.Services.AddAuthentication();
//PersonContext added as a scoped (default of method AddDbContext) service:

// super super experimental this is probobaly super wrong but oh well its this or making the same methods over and over and over AAAA
builder.Services.AddTransient<ICRUDinterface<Client>, CrudService<Client>>();
builder.Services.AddTransient<ICRUDinterface<Inventory>, CrudService<Inventory>>();
builder.Services.AddTransient<ICRUDinterface<ItemGroup>, CrudService<ItemGroup>>();
builder.Services.AddTransient<ICRUDinterface<ItemLine>, CrudService<ItemLine>>();
builder.Services.AddTransient<ICRUDinterface<ItemType>, CrudService<ItemType>>();
builder.Services.AddTransient<ICRUDinterface<Item>, CrudService<Item>>();
builder.Services.AddTransient<ICRUDinterface<Location>, CrudService<Location>>();
builder.Services.AddTransient<ICRUDinterface<Order>, CrudService<Order>>();
builder.Services.AddTransient<ICRUDinterface<OrderItem>, CrudService<OrderItem>>();
builder.Services.AddTransient<ICRUDinterface<Shipment>, CrudService<Shipment>>();
builder.Services.AddTransient<ICRUDinterface<ShipmentItem>, CrudService<ShipmentItem>>();
builder.Services.AddTransient<ICRUDinterface<Supplier>, CrudService<Supplier>>();
builder.Services.AddTransient<ICRUDinterface<Transfer>, CrudService<Transfer>>();
builder.Services.AddTransient<ICRUDinterface<TransferItem>, CrudService<TransferItem>>();
builder.Services.AddTransient<ICRUDinterface<Warehouse>, CrudService<Warehouse>>();
//
// DB hier aangemaakt
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


