using immid;
using immid.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
string connection = builder.Configuration.GetConnectionString("DefaultConnection"); //�������� ������ ����������� �� ����� ������������
builder.Services.AddDbContext<ProjectContext>(options => options.UseSqlServer(connection)); //��������� �������� � �������� ������� � ����������
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option => option.LoginPath = "/login"); //���������� �������� ��������������
builder.Services.AddAuthorization(); //��������� �������� �����������
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

app.UseAuthentication(); //���������� middleware ��������������
app.UseAuthorization(); //��������� middleware �����������

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
        //�������� �������� �� �������� � �������� �������������
        ProjectContext content = scope.ServiceProvider.GetRequiredService<ProjectContext>();
        SampleData.Initialize(content);
    }
    catch(Exception ex)
    {
        //���� ������, �������� ����������� ����� ������ �����
        var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error uccurred seeding the Db.");
    }
}

app.Run();
