using Microsoft.EntityFrameworkCore;
using Final_Project.Interfaces;
using Final_Project.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MemberContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("MemberContext")));

builder.Services.AddSwaggerDocument();

builder.Services.AddScoped<IFF,FFService>();
builder.Services.AddScoped<ITM, TMService>();
builder.Services.AddScoped<IH, HOService>();
builder.Services.AddScoped<IFT, FTService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<MemberContext>();
    context.Database.EnsureCreated();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseOpenApi();
app.UseSwaggerUi3();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
