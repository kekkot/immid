using immid.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
string connection = builder.Configuration.GetConnectionString("DefaultConnection"); //Получаем строку подключения из файла конфигурации
builder.Services.AddDbContext<ProjectContext>(options => options.UseSqlServer(connection)); //Добавляем контекст в качестве сервиса в приложение
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "project",
    pattern: "{controller=Project}/{action=Index}/{id?}");

using (var scope = app.Services.CreateScope())
{
    try
    {
        //Получаем контекст из сервисов и вызываем инициализатор
        ProjectContext content = scope.ServiceProvider.GetRequiredService<ProjectContext>();
        SampleData.Initialize(content);
    }
    catch(Exception ex)
    {
        //Если ошибка, получаем логирование через сервис логов
        var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error uccurred seeding the Db.");
    }
}

app.Run();
