using KeyedServicesWebApplication.Interfaces;
using KeyedServicesWebApplication.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddKeyedTransient<INotificationService, SmsNotificationService>(NotificationEnum.Sms.ToString());
builder.Services.AddKeyedTransient<INotificationService, EmailNotificationService>(NotificationEnum.Email.ToString());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
