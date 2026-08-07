using Microsoft.EntityFrameworkCore;
using SocialConnectApi.Data;
using SocialConnectApi.Service;
using SocialConnectApi.Services;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUsuarioService,UsuarioService>();
builder.Services.AddScoped<IPublicacaoService,PublicacaoService>();
builder.Services.AddScoped<IComentarioService,ComentarioService>();
builder.Services.AddScoped<ICurtidaService,CurtidaService>();
builder.Services.AddScoped<ISeguidorService,SeguidorService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();


app.UseAuthorization();


app.MapControllers();


app.Run();

