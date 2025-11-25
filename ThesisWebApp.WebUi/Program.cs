using GemBox.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using ThesisWebApp.Application;
using ThesisWebApp.Application.Interfaces;
using ThesisWebApp.Infrastructure;
using ThesisWebApp.Infrastructure.Data;
using ThesisWebApp.Infrastructure.Services;
using ThesisWebApp.Infrastructure.Repositories;
using ThesisWebApp.WebUi.Components;
using ThesisWebApp.WebUi.State;

var builder = WebApplication.CreateBuilder(args);


SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices();
builder.Services.AddDbContextFactory<SandboxContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IProjectSectionRepository, ProjectSectionRepository>();
builder.Services.AddScoped<IComponentRepository, ComponentRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddSingleton<SelectionService>();
builder.Services.AddTransient<IExcelExport, ExcelExport>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
