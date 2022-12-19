using MatchMakerDBU.Services;

var builder = WebApplication.CreateBuilder(args);

//Nikolaj og Bj�rn

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ISpillerService, SpillerServiceJson>();
//builder.Services.AddSingleton<ISpillerService, SpillerService>(); //hack
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
//test// 