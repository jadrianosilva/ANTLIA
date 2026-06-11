using Microsoft.EntityFrameworkCore;
using MovimentosManuais.Backend.Models;
using MovimentosManuais.Backend.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MovimentosContext>(options =>
    options.UseSqlServer("Server=.\\SQLEXPRESS;Database=MovimentosManuais;User Id=candidato;Password=candidato123;TrustServerCertificate=True"));

// Injeção de dependência com interfaces
builder.Services.AddScoped<IMovimentoService, MovimentoService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();

builder.Services.AddControllers();
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
