using OrderFlowManagementFrontend.Components;
using MudBlazor.Services;
using System.Threading.Tasks;
using OrderFlowManagementFrontend.Data;
using FluentAssertions.Common;
using OrderFlowManagementFrontend.Components.Pages;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices();
builder.Services.AddScoped<Registration>();
builder.Services.AddScoped<ElectronicResponse>();
builder.Services.AddScoped<RegistrationResponse>();
builder.Services.AddScoped<AllOrders>();
builder.Services.AddScoped<AllOrder>();
builder.Services.AddScoped<AllOrderResponse>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
